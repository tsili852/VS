using System;
using System.Collections.Generic;
using System.Text;

using Leadtools;
using Leadtools.Forms.Ocr;

using LeadTools170.Constants;
using Leadtools.Forms;
using Leadtools.Forms.Recognition;
using Unisystems.Cheques.EUR.Extraction;
using System.Drawing;
using Unisystems.Cheques.EUR.Model;

namespace LeadTools170.OCR
{
    public class OCRProcessor
    {
        private IOcrDocument document;

        public string OCRAmountZone(RasterImage image, RasterViewPerspective viewPerspective, IOcrEngine engine)
        {
            string result = string.Empty;

            document = engine.DocumentManager.CreateDocument();

            using (document)
            {

                IOcrPage page = document.Pages.AddPage(image, null);

                OcrZone zone = new OcrZone();

                image.ChangeViewPerspective(viewPerspective);

                int startingXPoint = image.ImageWidth - (image.ImageWidth / ChequeImageConstants.AmountZoneWidthDivider);
                int startingYPoint = 0;
                //image.ImageHeight - (image.ImageHeight / ChequeImageConstants.AmountZoneHeightDivider);

                LeadRect rect = new LeadRect(
                    startingXPoint, startingYPoint,
                    image.ImageWidth - startingXPoint,
                    image.ImageHeight - (image.ImageHeight / ChequeImageConstants.AmountZoneHeightDivider));

                zone.Bounds = new LogicalRectangle(rect);

                zone.ZoneType = OcrZoneType.Text;
                zone.RecognitionModule = OcrZoneRecognitionModule.OmniFontPlus2WayVoting;
                zone.FillMethod = OcrZoneFillMethod.OmniFont;
                page.Zones.Add(zone);

                result = page.RecognizeText(null);
            }

            return result;
        }

        public string ICRAmountZone(RasterImage image, RasterViewPerspective viewPerspective, IOcrEngine engine)
        {
            string result = string.Empty;

            document = engine.DocumentManager.CreateDocument();
            

            using (document)
            {
                IOcrPage page = document.Pages.AddPage(image, null);

                OcrZone zone = new OcrZone();

                image.ChangeViewPerspective(viewPerspective);

                int startingXPoint = image.ImageWidth - (image.ImageWidth / ChequeImageConstants.AmountZoneWidthDivider);
                int startingYPoint = 0;
                    
                    //image.ImageHeight - (image.ImageHeight / ChequeImageConstants.AmountZoneHeightDivider);

                LeadRect rect = new LeadRect(
                    startingXPoint, startingYPoint, 
                    image.ImageWidth - startingXPoint,
                    image.ImageHeight - (image.ImageHeight / ChequeImageConstants.AmountZoneHeightDivider));

                zone.Bounds = new LogicalRectangle(rect);

                zone.ZoneType = OcrZoneType.Text;
                zone.RecognitionModule = OcrZoneRecognitionModule.IcrNumeral;
                zone.FillMethod = OcrZoneFillMethod.Icr;
                page.Zones.Add(zone);

                result = page.RecognizeText(null);
            }

            return result;
        }

        public string OCRCodelineZoneOCRB(RasterImage image, RasterViewPerspective viewPerspective, IOcrEngine engine)
        {
            string result = string.Empty;

            document = engine.DocumentManager.CreateDocument();

            using (document)
            {
                IOcrPage page = document.Pages.AddPage(image, null);

                OcrZone zone = new OcrZone();

                image.ChangeViewPerspective(viewPerspective);

                int startingXPoint = image.ImageWidth - (image.ImageWidth / ChequeImageConstants.CodelineZoneWidthDivider);
                int startingYPoint = image.ImageHeight - (image.ImageHeight / ChequeImageConstants.CodelineZoneHeightDivider);

                LeadRect rect = new LeadRect(
                    startingXPoint, startingYPoint,
                    image.ImageWidth - startingXPoint,
                    image.ImageHeight - startingYPoint);

                zone.Bounds = new LogicalRectangle(rect);
                zone.ZoneType = OcrZoneType.Text;
                zone.FillMethod = OcrZoneFillMethod.OcrB | OcrZoneFillMethod.OmniFont;
                zone.RecognitionModule = OcrZoneRecognitionModule.OmniFontPlus2WayVoting;
                zone.RecognitionOptions = OcrZoneRecognitionOptions.DisableLanguageDictionary | OcrZoneRecognitionOptions.PassEntireLines | OcrZoneRecognitionOptions.DisableCorrection;

                page.Zones.Add(zone);

                string ocrResult = page.RecognizeText(null);

                IOcrPageCharacters ocrPageCharacters = page.GetRecognizedCharacters();

                foreach (IOcrZoneCharacters ocrZoneCharacters in ocrPageCharacters)
                {
                    for (int i = ocrZoneCharacters.Count - 1; i >= 0; i--)
                    {
                        OcrCharacter ocrCharacter = ocrZoneCharacters[i];
                        if (!EURChequeConstants.CodelinePermittedCharacters.Contains(ocrCharacter.Code.ToString()))
                        {
                            ocrCharacter.Code = char.Parse("*");
                            ocrCharacter.Color = RasterColor.FromKnownColor(RasterKnownColor.Red);
                        }
                        ocrZoneCharacters[i] = ocrCharacter;
                    }
                }

                page.SetRecognizedCharacters(ocrPageCharacters);
                string filteredOCR = page.GetRecognizedCharacters().ToString();

                EURFieldsExtractor fe = new EURFieldsExtractor();
                result = fe.ExtractCodeline(page.RecognizeText(null));

            }

            return result;
        }

        public string OCRCodelineZoneOmni(RasterImage image, RasterViewPerspective viewPerspective, IOcrEngine engine)
        {
            string result = string.Empty;

            document = engine.DocumentManager.CreateDocument();

            using (document)
            {
                IOcrPage page = document.Pages.AddPage(image, null);

                OcrZone zone = new OcrZone();

                image.ChangeViewPerspective(viewPerspective);

                int startingXPoint = image.ImageWidth - (image.ImageWidth / ChequeImageConstants.CodelineZoneWidthDivider);
                int startingYPoint = image.ImageHeight - (image.ImageHeight / ChequeImageConstants.CodelineZoneHeightDivider);

                LeadRect rect = new LeadRect(
                    startingXPoint, startingYPoint,
                    image.ImageWidth - startingXPoint,
                    image.ImageHeight - startingYPoint);

                zone.Bounds = new LogicalRectangle(rect);

                zone.ZoneType = OcrZoneType.Text;
                zone.RecognitionModule = OcrZoneRecognitionModule.OmniFontFireWorx;
                zone.FillMethod = OcrZoneFillMethod.OmniFont;
                page.Zones.Add(zone);

                string ocrResult = page.RecognizeText(null);

                EURFieldsExtractor fe = new EURFieldsExtractor();
                result = fe.ExtractCodeline(ocrResult);

            }

            return result;
        }

    }
}
