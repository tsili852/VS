using System;
using System.IO;
using Microsoft.Win32;
using System.Drawing;
using System.Windows.Forms;

using Leadtools;
using Leadtools.Codecs;

namespace Leadtools.Demos
{
    public sealed class DemosGlobal
    {
        public static string ImagesFolder
        {
            get
            {
                string value = Path.GetFullPath(@"..\..\..\..\..\..\Images");
                if (!Directory.Exists(value))
                {
                    RegistryKey rk = Registry.LocalMachine.OpenSubKey(@"Software\LEAD Technologies, Inc.\Images");
                    if (rk == null)
                        rk = Registry.LocalMachine.OpenSubKey(@"Software\LEAD Technologies, Inc.\UnicodeImages");

                    if (rk != null)
                    {
                        value = rk.GetValue(null) as string;
                        rk.Close();
                    }
                }

                return value;
            }
        }

        public static RectangleF GetBoundingRectangle(PointF[] pts)
        {
            if (pts.Length == 2)
                return RectangleF.FromLTRB(
                   Math.Min(pts[0].X, pts[1].X),
                   Math.Min(pts[0].Y, pts[1].Y),
                   Math.Max(pts[0].X, pts[1].X),
                   Math.Max(pts[0].Y, pts[1].Y));
            else if (pts.Length == 4)
                return RectangleF.FromLTRB(
                   Math.Min(pts[0].X, Math.Min(pts[1].X, Math.Min(pts[2].X, pts[3].X))),
                   Math.Min(pts[0].Y, Math.Min(pts[1].Y, Math.Min(pts[2].Y, pts[3].Y))),
                   Math.Max(pts[0].X, Math.Max(pts[1].X, Math.Max(pts[2].X, pts[3].X))),
                   Math.Max(pts[0].Y, Math.Max(pts[1].Y, Math.Max(pts[2].Y, pts[3].Y))));
            else
            {
                float xMin = pts[0].X;
                float yMin = pts[0].Y;
                float xMax = xMin;
                float yMax = yMin;

                for (int i = 1; i < pts.Length; i++)
                {
                    xMin = Math.Min(xMin, pts[i].X);
                    yMin = Math.Min(yMin, pts[i].Y);
                    xMax = Math.Max(xMax, pts[i].X);
                    yMax = Math.Max(yMax, pts[i].Y);
                }

                return FixRectangle(RectangleF.FromLTRB(xMin, yMin, xMax, yMax));
            }
        }

        public static PointF[] GetBoundingPoints(RectangleF rc)
        {
            return new PointF[]
         {
            new PointF(rc.Left, rc.Top),
            new PointF(rc.Right, rc.Top),
            new PointF(rc.Right, rc.Bottom),
            new PointF(rc.Left, rc.Bottom)
         };
        }

        public static Rectangle GetBoundingRectangle(Point center, Size size)
        {
            return new Rectangle(
               center.X - size.Width / 2,
               center.Y - size.Height / 2,
               size.Width,
               size.Height);
        }

        public static RectangleF GetBoundingRectangle(PointF center, SizeF size)
        {
            return new RectangleF(
               center.X - size.Width / 2.0f,
               center.Y - size.Height / 2.0f,
               size.Width,
               size.Height);
        }

        public static Rectangle GetBoundingRectangle(RectangleF rc)
        {
            return FixRectangle(new Rectangle(
               (int)rc.Left,
               (int)rc.Top,
               (int)Math.Ceiling(rc.Width) + 1,
               (int)Math.Ceiling(rc.Height) + 1));
        }

        public static RectangleF GetBoundingRectangle(PointF pt1, PointF pt2)
        {
            return RectangleF.FromLTRB(
               Math.Min(pt1.X, pt2.X),
               Math.Min(pt1.Y, pt2.Y),
               Math.Max(pt1.X, pt2.X),
               Math.Max(pt1.Y, pt2.Y));
        }

        public static RectangleF FixRectangle(RectangleF rc)
        {
            if (rc.Left > rc.Right || rc.Top > rc.Bottom)
                return RectangleF.FromLTRB(
                   Math.Min(rc.Left, rc.Right),
                   Math.Min(rc.Top, rc.Bottom),
                   Math.Max(rc.Left, rc.Right),
                   Math.Max(rc.Top, rc.Bottom));
            else
                return rc;
        }

        public static Rectangle FixRectangle(Rectangle rc)
        {
            if (rc.Left > rc.Right || rc.Top > rc.Bottom)
                return Rectangle.FromLTRB(
                   Math.Min(rc.Left, rc.Right),
                   Math.Min(rc.Top, rc.Bottom),
                   Math.Max(rc.Left, rc.Right),
                   Math.Max(rc.Top, rc.Bottom));
            else
                return rc;
        }

        public static void SetDefaultComments(RasterImage rasterImage, RasterCodecs rasterCodecs)
        {
            rasterCodecs.Options.Save.Comments = true;

            RasterCommentMetadata commentSoftware = new RasterCommentMetadata();
            commentSoftware.Type = RasterCommentMetadataType.Software;
#if !FOR_WIN64
            commentSoftware.FromAscii("LEADTOOLS For .NET 32 bit");
#else
         commentSoftware.FromAscii("LEADTOOLS For .NET 64 bit");
#endif

            RasterCommentMetadata commentCopyright = new RasterCommentMetadata();
            commentCopyright.Type = RasterCommentMetadataType.Copyright;
            commentCopyright.FromAscii("Copyright (c) 1991-2007 LEAD Technologies, Inc.  All Rights Reserved.");

            rasterImage.Comments.Add(commentSoftware);
            rasterImage.Comments.Add(commentCopyright);
        }

        public static String GetOcrOutputFileName(IWin32Window owner, string filter)
        {
            String outFileName = "";
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            try
            {
                saveFileDlg.Filter = filter;
                saveFileDlg.FilterIndex = 1;

                if (saveFileDlg.ShowDialog(owner) == DialogResult.OK)
                    outFileName = saveFileDlg.FileName;
            }
            finally
            {
                saveFileDlg.Dispose();
            }

            return outFileName;
        }

        public static String GetOcrOutputPath(IWin32Window owner)
        {
            String outPath = "";
            FolderBrowserDialog browseDlg = new FolderBrowserDialog();
            try
            {
                browseDlg.ShowNewFolderButton = false;
                browseDlg.Description = "Select Output Folder:";
                if (browseDlg.ShowDialog(owner) == DialogResult.OK)
                    outPath = browseDlg.SelectedPath;
            }
            finally
            {
                browseDlg.Dispose();
            }

            return outPath;
        }
    }
}
