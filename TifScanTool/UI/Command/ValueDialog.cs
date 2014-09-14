using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Leadtools.Demos;
using Leadtools.ImageProcessing;
using Leadtools.ImageProcessing.Color;
using Leadtools.ImageProcessing.Effects;

namespace MainDemo
{
   public partial class ValueDialog : Form
   {
      public int Value;
      private TypeConstants _type;
      public enum TypeConstants
      {
         ScaleFactor,
         PaintIntensity,
         PaintContrast,
         PaintGamma,
         AutoCrop,
         Average,
         Gaussian,
         Median,
         Mosaic,
         Oilify,
         Posterize,
         Sharpen,
         Min,
         Max,
         Contrast,
         GammaCorrect,
         HistoContrast,
         Hue,
         Intensity,
         Saturation,
         Solarize,
      }

      private struct TypeProp
      {
         public TypeConstants Type;
         public string CaptionName;
         public string ValueName;
         public int InitialValue;
         public bool ReadInitialValue;
         public int Min;
         public int Max;
         public int MultiplyBy;

         public TypeProp(TypeConstants type, string captionName, string valueName, int initialValue, bool readInitialValue, int min, int max, int multiplyBy)
         {
            Type = type;
            CaptionName = captionName;
            ValueName = valueName;
            InitialValue = initialValue;
            ReadInitialValue = readInitialValue;
            Min = min;
            Max = max;
            MultiplyBy = multiplyBy;
         }
      }

      private static TypeProp[] _typeProp = new TypeProp[]
      {
         new TypeProp(TypeConstants.ScaleFactor,      "Scale Factor (%)",        "Scale Factor",      0, true,       1,   1000,   1),
         new TypeProp(TypeConstants.PaintIntensity,   "Paint Intensity",         "Paint Intensity",   0, true,    -100,    100,  10),
         new TypeProp(TypeConstants.PaintContrast,    "Paint Contrast",          "Paint Contrast",    0, true,    -100,    100,  10),
         new TypeProp(TypeConstants.PaintGamma,       "Paint Gamma",             "Paint Gamma",       0, true,      10,    500,   1),
         new TypeProp(TypeConstants.AutoCrop,         "Auto Crop (Trim)",        "Threshold",         0, true,       0,    244,   1),
         new TypeProp(TypeConstants.Average,          "Average",                 "Dimension",         3, false,      3,    255,   1),
         new TypeProp(TypeConstants.Gaussian,         "Gaussian",                "Radius",            0, false,      1,   1000,   1),
         new TypeProp(TypeConstants.Median,           "Median",                  "Dimension",         2, false,      2,     64,   1),
         new TypeProp(TypeConstants.Mosaic,           "Mosaic",                  "Dimension",         2, false,      2,     64,   1),
         new TypeProp(TypeConstants.Oilify,           "Oilify",                  "Dimension",         2, false,      2,    255,   1),
         new TypeProp(TypeConstants.Posterize,        "Posterize",               "Levels",            2, false,      2,     64,   1),
         new TypeProp(TypeConstants.Sharpen,          "Sharpen",                 "Sharpness",         0, false,   -100,    100,  10),
         new TypeProp(TypeConstants.Min,              "Min Filter",              "Sample Size",       1, false,      1,     32,   1),
         new TypeProp(TypeConstants.Max,              "Max Filter",              "Sample Size",       1, false,      1,     32,   1),
         new TypeProp(TypeConstants.Contrast,         "Contrast",                "Contrast",          0, false,   -100,    100,  10),
         new TypeProp(TypeConstants.GammaCorrect,     "Gamma Correct",           "Gamma",            10, false,     10,    500,   1),
         new TypeProp(TypeConstants.HistoContrast,    "Histo Contrast",          "Contrast",          0, false,   -100,    100,  10),
         new TypeProp(TypeConstants.Hue,              "Hue",                     "Angle",             0, false,   -360,    360,   1),
         new TypeProp(TypeConstants.Intensity,        "Intensity (Brightness)",  "Brightness",        0, false,   -100,    100,  10),
         new TypeProp(TypeConstants.Saturation,       "Saturation",              "Change",            0, false,   -100,    100,  10),
         new TypeProp(TypeConstants.Solarize,         "Solarize",                "Threshold",         0, false,      0,    255,   1)
      };


      public ValueDialog(TypeConstants type)
      {
         //
         // Required for Windows Form Designer support
         //
         InitializeComponent();

         //
         // TODO: Add any constructor code after InitializeComponent call
         //
         _type = type;
      }

      private void ValueDialog_Load(object sender, System.EventArgs e)
      {
         TypeProp prop = _typeProp[(int)_type];
         Text = prop.CaptionName;
         _gbOptions.Text = prop.ValueName;
         _numValue.Minimum = prop.Min;
         _numValue.Maximum = prop.Max;
         if (prop.ReadInitialValue)
            prop.InitialValue = Value;
         else
            Value = prop.InitialValue;

         DialogUtilities.SetNumericValue(_numValue, Value / prop.MultiplyBy);
      }

      private void _num_Leave(object sender, System.EventArgs e)
      {
         DialogUtilities.NumericOnLeave(sender);
      }

      private void _btnOk_Click(object sender, System.EventArgs e)
      {
         int index = (int)_type;
         Value = (int)_numValue.Value * _typeProp[index].MultiplyBy;
         _typeProp[index].InitialValue = Value;
      }
   }
}