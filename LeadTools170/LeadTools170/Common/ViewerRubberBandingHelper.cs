using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

using Leadtools;
using Leadtools.WinForms;

#if ! LEADTOOLS_V17_OR_LATER
using LeadPoint = System.Drawing.Point;
using LeadSize = System.Drawing.Size;
using LeadRect = System.Drawing.Rectangle;
using Leadtools.Drawing;
#endif // #if !LEADTOOLS_V17_OR_LATER

#if LEADTOOLS_V17_OR_LATER
using Leadtools.Drawing;
#endif // #if LEADTOOLS_V17_OR_LATER

namespace Leadtools.Demos
{
   internal enum ViewerRubberBandingHelperMode
   {
      Draw,
      Move,
      Resize,
   }

   internal enum ViewerRubberBandingControlPoint
   {
      TopLeft,
      TopRight,
      BottomRight,
      BottomLeft,
      Inside
   }

   internal class ViewerRubberBandingHelperEventArgs : EventArgs
   {
      private Rectangle _bounds;
      private ViewerRubberBandingHelperMode _mode;

      internal ViewerRubberBandingHelperEventArgs(Rectangle bounds, ViewerRubberBandingHelperMode mode)
      {
         _bounds = bounds;
         _mode = mode;
      }

      public ViewerRubberBandingHelperMode Mode
      {
         get { return _mode; }
      }

      // The rubberband rectangle in image coordinates (pixels)
      public Rectangle Bounds
      {
         get { return _bounds; }
      }
   }

   // Helper class to uncapsulate drawing a rubberband on a RasterImageViewer
   internal class ViewerRubberBandingHelper : IDisposable
   {
      // The viewer we are drawing on
      private RasterImageViewer _viewer;
      // Are we currently rubber banding
      private bool _isRubberBanding;
      // The current rubber band rectangle
      private Rectangle _rubberBandingRectangle;
      // Flag to indicates if the rubber band rectangle is drawn
      private bool _isRubberBandingRectangleDrawn;
      // Did we clip the cursor?
      private Rectangle _saveClipRectangle;
      private bool _started;
      private bool _enableAutomation;
      private ViewerRubberBandingControlPoint _resizeCorner;
      private ViewerRubberBandingHelperMode _mode;
      private Point _originalMovePoint;
      private Rectangle _containerRectangle;
      private List<Rectangle> _rectangles;
      private int _selRectangleIndex;

      public event EventHandler<ViewerRubberBandingHelperEventArgs> RubberBand;

      public ViewerRubberBandingHelper()
      {
         _rectangles = new List<Rectangle>();
         _enableAutomation = true;
      }

      public void Dispose()
      {
         Dispose(true);
         GC.SuppressFinalize(this);
      }

      ~ViewerRubberBandingHelper()
      {
         Dispose(true);
      }

      private void Dispose(bool disposing)
      {
         if (disposing)
         {
            if (_rectangles != null)
            {
               _rectangles.Clear();

               // Un-subclass to the events
               if (_viewer != null)
               {
                  _viewer.MouseDown -= new MouseEventHandler(_viewer_MouseDown);
                  _viewer.MouseMove -= new MouseEventHandler(_viewer_MouseMove);
                  _viewer.MouseUp -= new MouseEventHandler(_viewer_MouseUp);
                  _viewer.LostFocus -= new EventHandler(_viewer_LostFocus);
               }
            }
         }
      }

      public void Start()
      {
         _mode = ViewerRubberBandingHelperMode.Draw;
         _viewer.Focus();

         _started = true;
      }

      private void StartResize(Rectangle rect, ViewerRubberBandingControlPoint corner)
      {
         _mode = ViewerRubberBandingHelperMode.Resize;

         _resizeCorner = corner;
         _started = true;
         _viewer.Focus();

         // Start the rubber banding
         BeginRubberBanding(rect);
      }

      private void StartMove(Rectangle rect)
      {
         _mode = ViewerRubberBandingHelperMode.Move;

         _started = true;
         _viewer.Focus();

         // Start the rubber banding
         BeginRubberBanding(rect);
      }

      public void Stop()
      {
         _isRubberBanding = false;
         _rubberBandingRectangle = Rectangle.Empty;
         _isRubberBandingRectangleDrawn = false;
         _saveClipRectangle = Rectangle.Empty;
         _started = false;

         ClipCursor(false);
      }

      // Begins the rubber banding operation
      private void BeginRubberBanding(Rectangle rect)
      {
         _rubberBandingRectangle = rect;
         _containerRectangle = Rectangle.Empty;

         _isRubberBanding = true;
         _viewer.Capture = true;

         // Clip the cursor
         ClipCursor(true);

         DrawRubberBandRectangle();
      }

      // Ends the rubber banding
      private void EndRubberBanding()
      {
         _viewer.Capture = false;
         _isRubberBanding = false;

         if(_isRubberBandingRectangleDrawn)
            DrawRubberBandRectangle();
      }

      private void ClipCursor(bool clip)
      {
         if(clip)
         {
            Rectangle rect = Rectangle.Intersect(FixRectangle(_viewer.PhysicalViewRectangle), _viewer.ClientRectangle);
            rect = _viewer.RectangleToScreen(rect);
            Control parent = _viewer.Parent;
            while(parent != null)
            {
               rect = Rectangle.Intersect(rect, _viewer.Parent.RectangleToScreen(_viewer.Parent.ClientRectangle));
               if(parent is Form)
               {
                  Form form = parent as Form;
                  if(form.IsMdiChild)
                  {
                     if(form.Owner != null)
                        rect = Rectangle.Intersect(rect, form.Owner.RectangleToScreen(form.Owner.ClientRectangle));
                     else if(form.Parent != null)
                        rect = Rectangle.Intersect(rect, form.Parent.RectangleToScreen(form.Parent.ClientRectangle));
                  }
               }

               parent = parent.Parent;
            }

            rect.Height += 1;
            rect.Width += 1;

            _saveClipRectangle = Cursor.Clip;
            Cursor.Clip = rect;
         }
         else
         {
            Cursor.Clip = _saveClipRectangle;
            _saveClipRectangle = Rectangle.Empty;
         }
      }

      private static Rectangle FixRectangle(Rectangle rect)
      {
         if(rect.Left > rect.Right)
            rect = Rectangle.FromLTRB(rect.Right, rect.Top, rect.Left, rect.Bottom);
         if(rect.Top > rect.Bottom)
            rect = Rectangle.FromLTRB(rect.Left, rect.Bottom, rect.Right, rect.Top);

         return rect;
      }

      // Draws the rubberband rectangle on the viewer
      private void DrawRubberBandRectangle()
      {
         Rectangle rect = FixRectangle(_rubberBandingRectangle);
         rect.Width++;
         rect.Height++;
         rect = _viewer.RectangleToScreen(rect);
         ControlPaint.DrawReversibleFrame(rect, Color.Transparent, FrameStyle.Thick);

         _isRubberBandingRectangleDrawn = !_isRubberBandingRectangleDrawn;
      }

      private void _viewer_MouseDown(object sender, MouseEventArgs e)
      {
         if (_viewer == null || !_started)
            return;

         _viewer.Focus();

         // Cancel rubber banding if it is on
         if (_isRubberBanding && e.Button != MouseButtons.Left)
            EndRubberBanding();
         else
         {
            if (_viewer.IsImageAvailable && e.Button == MouseButtons.Left)
            {
               // See if we click is on the image
               Rectangle rect = _viewer.PhysicalViewRectangle;
               if (rect.Contains(e.X, e.Y))
               {
                  Point testPoint = new Point(e.X, e.Y);
                  _selRectangleIndex = GetSelectedRectangleIndex();
                  if (_selRectangleIndex >= 0) // There is a selected rectangle
                  {
                     ViewerRubberBandingControlPoint controlPoint = GetCursorPos(testPoint);
                     if (controlPoint != ViewerRubberBandingControlPoint.TopLeft && controlPoint != ViewerRubberBandingControlPoint.TopRight &&
                         controlPoint != ViewerRubberBandingControlPoint.BottomRight && controlPoint != ViewerRubberBandingControlPoint.BottomLeft &&
                         controlPoint != ViewerRubberBandingControlPoint.Inside)
                     {
                        // the user pressed outside the selected rectangle boundaries, so deselect the selected rectangle.
                        _selRectangleIndex = -1;
                        _containerRectangle = Rectangle.Empty;
                     }
                  }

                  // Check if there is any rectangle where the user pressed then select it (unless it's already selected).
                  int index = HitTestRubberBandRectangle(testPoint);
                  if (index >= 0 && index != _selRectangleIndex)
                  {
                     _selRectangleIndex = index;
                     _containerRectangle = _rectangles[_selRectangleIndex];
                  }

                  if (_selRectangleIndex >= 0 && _enableAutomation)
                  {
                     ViewerRubberBandingControlPoint controlPoint = GetCursorPos(testPoint);
                     if (controlPoint == ViewerRubberBandingControlPoint.TopLeft || controlPoint == ViewerRubberBandingControlPoint.TopRight ||
                         controlPoint == ViewerRubberBandingControlPoint.BottomRight || controlPoint == ViewerRubberBandingControlPoint.BottomLeft)
                     {
                        StartResize(_containerRectangle, controlPoint);
                     }
                     else if (controlPoint == ViewerRubberBandingControlPoint.Inside) // Move
                     {
                        // Save the first point position to use it to offset the rubber band rectangle
                        // when the mode is "Move".
                        _originalMovePoint = testPoint;

                        StartMove(_containerRectangle);
                     }
                     else
                     {
                        // Start the rubber banding
                        BeginRubberBanding(Rectangle.FromLTRB(e.X, e.Y, e.X, e.Y));
                     }
                  }
                  else
                  {
                     _selRectangleIndex = -1;
                     // Start the rubber banding
                     BeginRubberBanding(Rectangle.FromLTRB(e.X, e.Y, e.X, e.Y));
                  }
               }
            }
         }
      }

      int HitTestRubberBandRectangle(Point pt)
      {
         for (int i = 0; i < _rectangles.Count; i++)
         {
            if (_rectangles[i].Contains(pt))
            {
               return i;
            }
         }

         return -1;
      }

      private void _viewer_MouseMove(object sender, MouseEventArgs e)
      {
         // Change the mouse cursor when hovering over the selected rectangle
         ChangeMouseCursor(new Point(e.X, e.Y));

         if(_isRubberBanding)
         {
            DrawRubberBandRectangle();

            switch (_mode)
            {
               case ViewerRubberBandingHelperMode.Draw:
                  _rubberBandingRectangle = Rectangle.FromLTRB(
                     _rubberBandingRectangle.Left,
                     _rubberBandingRectangle.Top,
                     e.X,
                     e.Y);
                  break;

               case ViewerRubberBandingHelperMode.Resize:
                  switch (_resizeCorner)
                  {
                     case ViewerRubberBandingControlPoint.TopLeft:
                        _rubberBandingRectangle = Rectangle.FromLTRB(
                           e.X,
                           e.Y,
                           _rubberBandingRectangle.Right,
                           _rubberBandingRectangle.Bottom);
                        break;

                     case ViewerRubberBandingControlPoint.TopRight:
                        _rubberBandingRectangle = Rectangle.FromLTRB(
                           _rubberBandingRectangle.Left,
                           e.Y,
                           e.X,
                           _rubberBandingRectangle.Bottom);
                        break;

                     case ViewerRubberBandingControlPoint.BottomRight:
                        _rubberBandingRectangle = Rectangle.FromLTRB(
                           _rubberBandingRectangle.Left,
                           _rubberBandingRectangle.Top,
                           e.X,
                           e.Y);
                        break;

                     case ViewerRubberBandingControlPoint.BottomLeft:
                        _rubberBandingRectangle = Rectangle.FromLTRB(
                           e.X,
                           _rubberBandingRectangle.Top,
                           _rubberBandingRectangle.Right,
                           e.Y);
                        break;
                  }
                  break;

               case ViewerRubberBandingHelperMode.Move:
                  _rubberBandingRectangle.Offset(e.X - _originalMovePoint.X, e.Y - _originalMovePoint.Y);
                  _originalMovePoint.X = e.X;
                  _originalMovePoint.Y = e.Y;
                  break;
            }

            DrawRubberBandRectangle();
         }
      }

      private void _viewer_MouseUp(object sender, MouseEventArgs e)
      {
         ClipCursor(false);

         if(_isRubberBanding)
         {
            // Save the rubberband rectangle
            Rectangle rect = _rubberBandingRectangle;

            EndRubberBanding();

            // Fire the event
            if(RubberBand != null)
            {
               // First, convert the rectangle to image coordinates
               rect = FixRectangle(rect);

               // Must be at least 1 pixel in size
               if(rect.Width > 1 && rect.Height > 1)
               {
                  _selRectangleIndex = GetSelectedRectangleIndex();
                  if (_rectangles.Count > 0 && _selRectangleIndex >= 0 && _rectangles.Count > _selRectangleIndex)
                     _rectangles[_selRectangleIndex] = rect;

                  rect = Rectangle.Round(RectangleToLogical(rect));
                  RubberBand(this, new ViewerRubberBandingHelperEventArgs(rect, _mode));
                  _mode = ViewerRubberBandingHelperMode.Draw;
               }
            }
         }
      }

      int GetSelectedRectangleIndex()
      {
         if (_rectangles == null || _containerRectangle == null || _containerRectangle.IsEmpty)
            return -1;

         for (int i = 0; i < _rectangles.Count; i++)
         {
            if (_rectangles[i].Equals(_containerRectangle))
            {
               return i;
            }
         }

         return -1;
      }

      private void _viewer_LostFocus(object sender, EventArgs e)
      {
         if(_isRubberBanding)
         {
            EndRubberBanding();
         }
      }

      public bool IsStarted
      {
         get
         {
            return _started;
         }
      }

      public ViewerRubberBandingHelperMode Mode
      {
         get
         {
            return _mode;
         }
      }

      public RasterImageViewer Viewer
      {
         get
         {
            return _viewer;
         }
         set
         {
            if(value != null)
            {
               _viewer = value;
               _viewer.MouseDown += new MouseEventHandler(_viewer_MouseDown);
               _viewer.MouseMove += new MouseEventHandler(_viewer_MouseMove);
               _viewer.MouseUp += new MouseEventHandler(_viewer_MouseUp);
               _viewer.LostFocus += new EventHandler(_viewer_LostFocus);
            }
            else
            {
               _viewer.MouseDown -= new MouseEventHandler(_viewer_MouseDown);
               _viewer.MouseMove -= new MouseEventHandler(_viewer_MouseMove);
               _viewer.MouseUp -= new MouseEventHandler(_viewer_MouseUp);
               _viewer.LostFocus -= new EventHandler(_viewer_LostFocus);

               _viewer = null;
            }
         }
      }

      public PointF PointToLogical(PointF pt)
      {
         using (Matrix transform = _viewer.GetTransformWithDpi())
         {
            Transformer t = new Transformer(transform);
            return t.PointToLogical(pt);
         }
      }

      public PointF PointToPhysical(PointF pt)
      {
         using (Matrix transform = _viewer.GetTransformWithDpi())
         {
            Transformer t = new Transformer(transform);
            return t.PointToPhysical(pt);
         }
      }

      public RectangleF RectangleToLogical(RectangleF rect)
      {
         using (Matrix transform = _viewer.GetTransformWithDpi())
         {
            Transformer t = new Transformer(transform);
            return t.RectangleToLogical(rect);
         }
      }

      public RectangleF RectangleToPhysical(RectangleF rect)
      {
         using (Matrix transform = _viewer.GetTransformWithDpi())
         {
            Transformer t = new Transformer(transform);
            return t.RectangleToPhysical(rect);
         }
      }

      public bool EnableAutomation
      {
         get
         {
            return _enableAutomation;
         }
         set
         {
            _enableAutomation = value;
         }
      }

      public void DrawRectangle(
         Graphics g, 
         Rectangle rect, 
         Pen rubberBandPen, 
         Pen containerPen, 
         bool showControlPoints)
      {
         if(!showControlPoints)
         {
            g.DrawRectangle(rubberBandPen, rect);
         }
         else
         {
            _containerRectangle = rect;
            // Draw the selected zone rectangle control points

            Rectangle controlPointRect1 = Rectangle.Empty;
            Rectangle controlPointRect2 = Rectangle.Empty;
            Rectangle controlPointRect3 = Rectangle.Empty;
            Rectangle controlPointRect4 = Rectangle.Empty;

            // Set the control points coordinates
            controlPointRect1 = new Rectangle(rect.Left - 5, rect.Top - 5, 10, 10);
            controlPointRect2 = new Rectangle(rect.Right - 5, rect.Top - 5, 10, 10);
            controlPointRect3 = new Rectangle(rect.Left - 5, rect.Bottom - 5, 10, 10);
            controlPointRect4 = new Rectangle(rect.Right - 5, rect.Bottom - 5, 10, 10);

            using(SolidBrush br = new SolidBrush(containerPen.Color))
            {
               g.DrawRectangle(containerPen, rect);
               g.FillRectangle(br, controlPointRect1);
               g.FillRectangle(br, controlPointRect2);
               g.FillRectangle(br, controlPointRect3);
               g.FillRectangle(br, controlPointRect4);
            }
         }
      }

      public ViewerRubberBandingControlPoint GetCursorPos(Point pt)
      {
         Rectangle rc = GetLTSelCorner();
         if (rc.Contains(pt))
            return ViewerRubberBandingControlPoint.TopLeft;

         rc = GetRTSelCorner();
         if (rc.Contains(pt))
            return ViewerRubberBandingControlPoint.TopRight;

         rc = GetRBSelCorner();
         if (rc.Contains(pt))
            return ViewerRubberBandingControlPoint.BottomRight;

         rc = GetLBSelCorner();
         if (rc.Contains(pt))
            return ViewerRubberBandingControlPoint.BottomLeft;

         /* check if the point inside the selected zone */
         if (_containerRectangle.Contains(pt))
            return ViewerRubberBandingControlPoint.Inside;

         return (ViewerRubberBandingControlPoint)(-1);
      }

      private Rectangle GetLTSelCorner()
      {
         return new Rectangle(_containerRectangle.Left - 5, _containerRectangle.Top - 5, 10, 10);
      }

      private Rectangle GetRTSelCorner()
      {
         return new Rectangle(_containerRectangle.Right - 5, _containerRectangle.Top - 5, 10, 10);
      }

      private Rectangle GetLBSelCorner()
      {
         return new Rectangle(_containerRectangle.Left - 5, _containerRectangle.Bottom - 5, 10, 10);
      }

      private Rectangle GetRBSelCorner()
      {
         return new Rectangle(_containerRectangle.Right - 5, _containerRectangle.Bottom - 5, 10, 10);
      }

      private void ChangeMouseCursor(Point pt)
      {
         if(!IsStarted || !_viewer.IsImageAvailable)
         {
            _viewer.Cursor = Cursors.Default;
            return;
         }

         // check if the point is outside the image boundaries then show the default cursor
         if (_viewer.PhysicalViewRectangle.Contains(pt))
            _viewer.Cursor = Cursors.Cross;
         else
            _viewer.Cursor = Cursors.Default;

         if(!_enableAutomation)
         {
            return;
         }

         ViewerRubberBandingControlPoint controlPoint = GetCursorPos(pt);

         switch (controlPoint)
         {
            case ViewerRubberBandingControlPoint.TopLeft:
            case ViewerRubberBandingControlPoint.BottomRight:
               _viewer.Cursor = Cursors.SizeNWSE;
               break;

            case ViewerRubberBandingControlPoint.TopRight:
            case ViewerRubberBandingControlPoint.BottomLeft:
               _viewer.Cursor = Cursors.SizeNESW;
               break;

            case ViewerRubberBandingControlPoint.Inside:
               _viewer.Cursor = Cursors.NoMove2D;
               break;

            default:
               int index = HitTestRubberBandRectangle(pt);
               if (index >= 0)
                  _viewer.Cursor = Cursors.Default;
               else
               {
                  // check if the point is outside the image boundaries then show the default cursor
                  if (_viewer.PhysicalViewRectangle.Contains(pt))
                     _viewer.Cursor = Cursors.Cross;
                  else
                     _viewer.Cursor = Cursors.Default;
               }
               break;
         }
      }

      public List<Rectangle> Rectangles
      {
         get
         {
            return _rectangles;
         }
      }

      public Rectangle ContainerRectangle
      {
         get
         {
            return _containerRectangle;
         }
         set
         {
            _containerRectangle = value;
         }
      }
   }
}
