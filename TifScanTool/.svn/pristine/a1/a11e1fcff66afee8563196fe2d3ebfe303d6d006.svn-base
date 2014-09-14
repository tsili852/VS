using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Leadtools.ImageProcessing.Effects;

namespace MainDemo
{
   public partial class SpatialDialog : Form
   {
      private static SpatialFilterCommandPredefined _initialFilter = SpatialFilterCommandPredefined.SobelVertical;

      public SpatialFilterCommandPredefined Filter;

      public SpatialDialog()
      {
         InitializeComponent();
      }

      private void SpatialDialog_Load(object sender, System.EventArgs e)
      {
         Filter = _initialFilter;

         Tools.FillComboBoxWithEnum(_cbFilter, typeof(SpatialFilterCommandPredefined), Filter);
      }

      private void _btnOk_Click(object sender, System.EventArgs e)
      {
         Filter = (SpatialFilterCommandPredefined)Constants.GetValueFromName(
            typeof(SpatialFilterCommandPredefined),
            (string)_cbFilter.SelectedItem,
            _initialFilter);

         _initialFilter = Filter;
      }
   }
}