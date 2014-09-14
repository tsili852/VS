using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Leadtools.Demos;
using Leadtools;
using Leadtools.ImageProcessing.Effects;
using Leadtools.ImageProcessing.Core;

namespace MainDemo
{
   public partial class BorderRemoveDialog : Form
   {
      private static bool _firstTimer = true;
      private static BorderRemoveCommandFlags _initialFlags;
      private static BorderRemoveBorderFlags _initialBorder;
      private static int _initialPercent;
      private static int _initialVariance;
      private static int _initialWhiteNoiseLength;

      public BorderRemoveCommandFlags Flags;
      public BorderRemoveBorderFlags Border;
      public int Percent;
      public int Variance;
      public int WhiteNoiseLength;

      public BorderRemoveDialog()
      {
         InitializeComponent();
      }

      private void BorderRemoveDialog_Load(object sender, System.EventArgs e)
      {
         if (_firstTimer)
         {
            _firstTimer = false;
            BorderRemoveCommand command = new BorderRemoveCommand();
            _initialFlags = command.Flags;
            _initialBorder = command.Border;
            _initialPercent = command.Percent;
            _initialVariance = command.Variance;
            _initialWhiteNoiseLength = command.WhiteNoiseLength;
         }

         Flags = _initialFlags;
         Border = _initialBorder;
         Percent = _initialPercent;
         Variance = _initialVariance;
         WhiteNoiseLength = _initialWhiteNoiseLength;

         _cbImageUnchanged.Checked = (Flags & BorderRemoveCommandFlags.ImageUnchanged) == BorderRemoveCommandFlags.ImageUnchanged;
         _cbUseVariance.Checked = (Flags & BorderRemoveCommandFlags.UseVariance) == BorderRemoveCommandFlags.UseVariance;

         _cbLeft.Checked = (Border & BorderRemoveBorderFlags.Left) == BorderRemoveBorderFlags.Left;
         _cbTop.Checked = (Border & BorderRemoveBorderFlags.Top) == BorderRemoveBorderFlags.Top;
         _cbRight.Checked = (Border & BorderRemoveBorderFlags.Right) == BorderRemoveBorderFlags.Right;
         _cbBottom.Checked = (Border & BorderRemoveBorderFlags.Bottom) == BorderRemoveBorderFlags.Bottom;

         _numPercent.Value = Percent;
         _numVariance.Value = Variance;
         _numWhiteNoiseLength.Value = WhiteNoiseLength;

         UpdateControls();
      }

      private void _num_Leave(object sender, System.EventArgs e)
      {
         DialogUtilities.NumericOnLeave(sender);
      }

      private void _btnOk_Click(object sender, System.EventArgs e)
      {
         Flags = BorderRemoveCommandFlags.None;

         if (_cbImageUnchanged.Checked) Flags |= BorderRemoveCommandFlags.ImageUnchanged;
         if (_cbUseVariance.Checked) Flags |= BorderRemoveCommandFlags.UseVariance;

         Border = BorderRemoveBorderFlags.None;

         if (_cbLeft.Checked) Border |= BorderRemoveBorderFlags.Left;
         if (_cbTop.Checked) Border |= BorderRemoveBorderFlags.Top;
         if (_cbRight.Checked) Border |= BorderRemoveBorderFlags.Right;
         if (_cbBottom.Checked) Border |= BorderRemoveBorderFlags.Bottom;

         Percent = (int)_numPercent.Value;
         Variance = (int)_numVariance.Value;
         WhiteNoiseLength = (int)_numWhiteNoiseLength.Value;

         _initialFlags = Flags;
         _initialBorder = Border;
         _initialPercent = Percent;
         _initialVariance = Variance;
         _initialWhiteNoiseLength = WhiteNoiseLength;
      }

      private void _cbUseVariance_CheckedChanged(object sender, System.EventArgs e)
      {
         UpdateControls();
      }

      private void UpdateControls()
      {
         _lblVariance.Enabled = _cbUseVariance.Checked;
         _numVariance.Enabled = _cbUseVariance.Checked;
      }
   }
}