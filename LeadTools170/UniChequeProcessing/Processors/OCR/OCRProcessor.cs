using System;
using System.Collections.Generic;
using System.Text;
using Leadtools.Forms.Ocr;
using Leadtools;
using Unisystems.Cheques.UniChequeProcessing.Constants;
using Leadtools.Forms;
using Unisystems.Cheques.EUR.Extraction;
using Unisystems.Cheques.EUR.Model;

namespace Unisystems.Cheques.UniChequeProcessing.Processors.OCR
{
    public class OCRProcessor
    {
        public string OCRAmountZone(RasterImage image, RasterViewPerspective viewPerspective, IOcrEngine engine)
        {
            string result = string.Empty;

            IOcrDocument document = engine.DocumentManager.CreateDocument();

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

            IOcrDocument document = engine.DocumentManager.CreateDocument();

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
                // N.T.
                //zone.RecognitionModule = OcrZoneRecognitionModule.IcrNumeral;
                zone.RecognitionModule = OcrZoneRecognitionModule.Auto;
                zone.FillMethod = OcrZoneFillMethod.OcrA;
                page.Zones.Add(zone);

                result = page.RecognizeText(null);
            }

            return result;
        }

        public string OCRCodelineZoneOCRB(RasterImage image, RasterViewPerspective viewPerspective, IOcrEngine engine)
        {
            string result = string.Empty;            

            IOcrDocument document = engine.DocumentManager.CreateDocument();

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

                EURFieldsExtractor fe = new EURFieldsExtractor();
                result = fe.ExtractCodeline(page.RecognizeText(null));

            }

            return result;
        }

        public string OCRCodelineZoneOmni(RasterImage image, RasterViewPerspective viewPerspective, IOcrEngine engine)
        {
            string result = string.Empty;

            IOcrDocument document = engine.DocumentManager.CreateDocument();

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
                zone.RecognitionModule = OcrZoneRecognitionModule.Auto;
                zone.FillMethod = OcrZoneFillMethod.OmniFont;
                page.Zones.Add(zone);

                string ocrResult = page.RecognizeText(null);

                EURFieldsExtractor fe = new EURFieldsExtractor();
                result = fe.ExtractCodeline(ocrResult);

            }

            return result;
        }

        public string OCRRubberBandZone(RasterImage image, RasterViewPerspective viewPerspective, LogicalRectangle rect, IOcrEngine engine)
        {
            string result = string.Empty;

            IOcrDocument document = engine.DocumentManager.CreateDocument();

            using (document)
            {
                IOcrPage page = document.Pages.AddPage(image, null);
                
                image.ChangeViewPerspective(viewPerspective);

                OcrZone zone = new OcrZone();
                zone.Bounds = rect;
                zone.ZoneType = OcrZoneType.Text;
                zone.FillMethod = OcrZoneFillMethod.OcrA;
                // N.T.
                //zone.RecognitionModule = OcrZoneRecognitionModule.IcrNumeral;
                zone.RecognitionModule = OcrZoneRecognitionModule.Auto;
                //zone.RecognitionModule = OcrZoneRecognitionModule.IcrCharacter | OcrZoneRecognitionModule.IcrNumeral;
                //zone.CharacterFilters = OcrZoneCharacterFilters.Digit;

                page.Zones.Add(zone);

                result = page.RecognizeText(null);

                if (String.Compare(result, string.Empty) == 0)
                    result = "Could not OCR any data on the image";
            }

            return result;

        }

    }
}
