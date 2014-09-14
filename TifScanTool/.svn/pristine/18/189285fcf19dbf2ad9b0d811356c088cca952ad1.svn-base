using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Leadtools;
using Leadtools.WinForms;
using System.IO;

namespace MainDemo
{
    public partial class ViewerForm : Form
    {
        public ViewerForm()
        {
            InitializeComponent();

            InitClass();
        }

        private RasterImageViewer _viewer;
        private string _name;
        public bool _saved;

        private void InitClass()
        {
            _viewer = new RasterImageViewer();
            _viewer.Dock = DockStyle.Fill;
            _viewer.BorderStyle = BorderStyle.None;
            _viewer.SizeModeChanged += new EventHandler(_viewer_SizeModeChanged);
            _viewer.DragEnter += new DragEventHandler(_viewer_DragEnter);
            _viewer.DragDrop += new DragEventHandler(_viewer_DragDrop);
            _viewer.InteractiveModeEnded += new EventHandler(_viewer_EnterActiveModeEnded);
            _viewer.KeyDown += new KeyEventHandler(_viewer_KeyDown);
            _viewer.FloaterImageChanged += new EventHandler(_viewer_FloaterImageChanged);
            _viewer.FloaterVisibleChanged += new EventHandler(_viewer_FloaterVisibleChanged);
            Controls.Add(_viewer);
            _viewer.BringToFront();
            _viewer.AllowDrop = true;
            _saved = false;

        }

        public void Initialize(ImageInformation info, RasterPaintProperties paintProperties, bool snap)
        {
            _viewer.BeginUpdate();
            UpdatePaintProperties(paintProperties);
            _viewer.Image = info.Image;
            if (_viewer.Image != null)
                _viewer.Image.Changed += new EventHandler<RasterImageChangedEventArgs>(Image_Changed);
            _name = info.Name;
            if (snap)
                Snap();
            UpdateCaption();
            _viewer.EndUpdate();
            
        }

        public void UpdatePaintProperties(RasterPaintProperties paintProperties)
        {
            _viewer.PaintProperties = paintProperties;
        }

        private void UpdateCaption()
        {
            // commented by unisystems 14/7/2008
            //Text = string.Format("{0} - Page {1}:{2}", _name, _viewer.Image.Page, _viewer.Image.PageCount);
            FileInfo fileInfo = new FileInfo(_name);
            if (_viewer.Image.Width==1 && _viewer.Image.Height==1)
                Text = string.Format("{0}{1}", fileInfo.Name, "*");
            else
            Text = string.Format("{0}{1}- Page {2}:{3}", fileInfo.Name,"*", _viewer.Image.Page, _viewer.Image.PageCount);
        }

        public RasterImage Image
        {
            get
            {
                return _viewer.Image;
            }
        }

        public RasterImageViewer Viewer
        {
            get
            {
                return _viewer;
            }
        }

        public bool Image_Saved()
        {
            _saved = true;
            Text = Text.Replace("*","");
            return true; 
            
        }

        private void Image_Changed(object sender, RasterImageChangedEventArgs e)
        {
            UpdateCaption();
            if (MdiParent != null)
                ((MainForm)MdiParent).UpdateControls();
        }


        private void _viewer_SizeModeChanged(object sender, EventArgs e)
        {
            ((MainForm)MdiParent).UpdateControls();
        }

        public void Snap()
        {
            _viewer.ClientSize = _viewer.PhysicalViewRectangle.Size;
            ClientSize = _viewer.ClientSize;
        }

        private void _viewer_DragEnter(object sender, DragEventArgs e)
        {
            if (Tools.CanDrop(e.Data))
                e.Effect = DragDropEffects.Copy;
        }

        private void _viewer_DragDrop(object sender, DragEventArgs e)
        {
            if (Tools.CanDrop(e.Data))
            {
                string[] files = Tools.GetDropFiles(e.Data);
                if (files != null)
                    ((MainForm)MdiParent).LoadDropFiles(this, files);
            }
        }

        private void _viewer_EnterActiveModeEnded(object sender, EventArgs e)
        {
            if (_viewer.InteractiveMode == RasterViewerInteractiveMode.Region)
            {
                _viewer.RegionToFloater();
                _viewer.FloaterVisible = true;
                _viewer.AnimateFloater = true;
                _viewer.InteractiveMode = RasterViewerInteractiveMode.Floater;
                _viewer.Image.MakeRegionEmpty();
                ((MainForm)MdiParent).UpdateControls();
            }
        }

        private void _viewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Handled)
            {
                if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
                {
                    e.Handled = true;

                    ((MainForm)MdiParent).Zoom(e.KeyCode == Keys.Add || e.KeyCode == Keys.Oemplus);
                }
            }
        }

        private void _viewer_FloaterImageChanged(object sender, EventArgs e)
        {
            ((MainForm)MdiParent).SetFloaterPaintValues();
        }

        private void _viewer_FloaterVisibleChanged(object sender, EventArgs e)
        {
            ((MainForm)MdiParent).SetFloaterPaintValues();
        }
    }
}