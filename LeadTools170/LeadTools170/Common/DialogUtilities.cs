using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Leadtools.Demos
{
   public static class DialogUtilities
   {
      public static bool ParseInteger(TextBox textBox, string name, int min, bool useMin, int max, bool useMax, bool cancelDialog, out int value)
      {
         try
         {
            value = int.Parse(textBox.Text);

            if (useMin && value < min)
               return Fail(textBox.FindForm(), cancelDialog, string.Format("'{0}' should not be less than {1}", name, min));

            if (useMax && value > max)
               return Fail(textBox.FindForm(), cancelDialog, string.Format("'{0}' should not be greater than {1}", name, max));

            return true;
         }
         catch (Exception ex)
         {
            value = 0;
            return Fail(textBox.FindForm(), cancelDialog, ex.Message);
         }
      }

      private static bool Fail(Form form, bool cancelDialog, string message)
      {
         Messager.ShowWarning(form, message);

         if (cancelDialog)
            form.DialogResult = DialogResult.None;

         return false;
      }

      public static void NumericOnLeave(object sender)
      {
         NumericUpDown num = sender as NumericUpDown;
         if (num.Value < num.Minimum)
            num.Value = num.Minimum;
         else if (num.Value > num.Maximum)
            num.Value = num.Maximum;
      }

      public static void SetNumericValue(NumericUpDown num, int value)
      {
         num.Value = Math.Max(num.Minimum, Math.Min(num.Maximum, value));
      }

      // Fix for the font issue in Windows 98 (Q326219)
      [DllImport("msvcrt.dll", EntryPoint = "_controlfp", CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
      private static extern int _controlfp(int IN_New, int IN_Mask);
      private const int _MCW_EW = 0x0008001f;
      private const int _EM_INVALID = 0x00000010;

      static public void RunFPU()
      {
         try
         {
            _controlfp(_MCW_EW, _EM_INVALID);
         }
         catch
         {
         }
      }

      // System.Windows.Forms.PrintPreviewDialog has a bug on Windows 98 that causes a crash.  Search groups.google.com for an explination and a potentional fix
      public static bool CanRunPrintPreview
      {
         get
         {
            OperatingSystem os = Environment.OSVersion;
            return (os.Platform != PlatformID.Win32Windows);
         }
      }
   }
}
