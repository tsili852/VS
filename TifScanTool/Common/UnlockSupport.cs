using System;
using System.Windows.Forms;

using Leadtools;

namespace Leadtools.Demos
{
    public sealed class Support
    {
        private Support()
        {
        }

        public static bool KernelExpired
        {
            get
            {
                if (RasterSupport.KernelExpired)
                {
                    MessageBox.Show(
                       null,
                       "This library has expired.  Contact LEAD Technologies, Inc. at (704) 332-5532 to order a new version.",
                       "LEADTOOLS for .NET 14.0 Evalutation Notice",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Stop);
                    return true;
                }
                else
                    return false;
            }
        }

        public static void Unlock(bool check)
        {
            
            RasterSupport.Unlock(RasterSupportType.Abc, "");
            RasterSupport.Unlock(RasterSupportType.AbicRead, "");
            RasterSupport.Unlock(RasterSupportType.AbicSave, "");
            RasterSupport.Unlock(RasterSupportType.Barcodes1D, "");
            RasterSupport.Unlock(RasterSupportType.Barcodes1DSilver, "");
            RasterSupport.Unlock(RasterSupportType.BarcodesDataMatrixRead, "");
            RasterSupport.Unlock(RasterSupportType.BarcodesDataMatrixWrite, "");
            RasterSupport.Unlock(RasterSupportType.BarcodesPdfRead, "");
            RasterSupport.Unlock(RasterSupportType.BarcodesPdfWrite, "");
            RasterSupport.Unlock(RasterSupportType.BarcodesQRRead, "");
            RasterSupport.Unlock(RasterSupportType.BarcodesQRWrite, "");
            RasterSupport.Unlock(RasterSupportType.Bitonal, "");
            RasterSupport.Unlock(RasterSupportType.Cmw, "");
            RasterSupport.Unlock(RasterSupportType.Dicom, "");
            RasterSupport.Unlock(RasterSupportType.Document, "");
            RasterSupport.Unlock(RasterSupportType.ExtGray, "");
            RasterSupport.Unlock(RasterSupportType.Icr, "");
            RasterSupport.Unlock(RasterSupportType.J2k, "");
            RasterSupport.Unlock(RasterSupportType.Jbig2, "");
            RasterSupport.Unlock(RasterSupportType.Pro, "LhwcFdF3jN");
            RasterSupport.Unlock(RasterSupportType.Medical, "");
            RasterSupport.Unlock(RasterSupportType.MedicalNet, "");
            RasterSupport.Unlock(RasterSupportType.Mobile, "");
            RasterSupport.Unlock(RasterSupportType.Nitf, "");
            RasterSupport.Unlock(RasterSupportType.Ocr, "");
            RasterSupport.Unlock(RasterSupportType.OcrArabic, "");
            RasterSupport.Unlock(RasterSupportType.OcrAsian, "");
            RasterSupport.Unlock(RasterSupportType.OcrPdfOutput, "");
            RasterSupport.Unlock(RasterSupportType.Omr, "");
            RasterSupport.Unlock(RasterSupportType.PdfAdvanced, "");
            RasterSupport.Unlock(RasterSupportType.PdfRead, "");
            RasterSupport.Unlock(RasterSupportType.PdfSave, "");
            RasterSupport.Unlock(RasterSupportType.Vector, "");

            if (check)
            {
                Array a = Enum.GetValues(typeof(RasterSupportType));
                foreach (RasterSupportType i in a)
                {
                    if (i != RasterSupportType.Vector && i != RasterSupportType.MedicalNet)
                    {
                        if (RasterSupport.IsLocked(i))
                            Messager.ShowWarning(null, string.Format("Locked: {0}", i));
                    }
                }
            }
        }
    }
}
