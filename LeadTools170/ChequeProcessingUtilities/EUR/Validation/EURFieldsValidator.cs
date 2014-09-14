using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Unisystems.Cheques.EUR;
using Unisystems.Cheques.EUR.Model;
using Unisystems.Cheques.EUR.Extraction;

namespace Unisystems.Cheques.EUR.Validation
{
    public static class EURFieldsValidator
    {
        public static bool ValidateAmountF1(string amount)
        {
            bool result = false;

            if (amount != null && String.Compare(amount, string.Empty) != 0)
            {
                double numericCheck = -1d;

                if (double.TryParse(amount, out numericCheck))
                {
                    result = true;
                }
 
            }

            return result;
 
        }

        public static bool ValidateChequeNoF2(string chequeNo)
        {
            bool result = false;

            if (chequeNo != null && String.Compare(chequeNo, string.Empty) != 0)
            {
                long numericCheck = -1;

                string tmpChequeNumber = chequeNo.Replace(" ", "").Trim();

                if (long.TryParse(tmpChequeNumber, out numericCheck))
                {
                    // Characters are numeric, continue and check for correct digit number
                    if (tmpChequeNumber.Length == EURChequeConstants.NumberLength)
                    {
                        // Checkdigit validation
                        // Modulo-11 validation
                        string noCheckDigit = tmpChequeNumber.Substring(0, EURChequeConstants.NumberLength - 1);

                        int checkDigit = CalculateChequeNumberCheckDigit(noCheckDigit);

                        if (
                            String.Compare(
                                tmpChequeNumber,
                                String.Concat(new string[] { noCheckDigit, checkDigit.ToString() })) == 0)
                        {
                            result = true;
                        }
                    }
                    else
                    {
                        // Field length does not comply with the required value
                        result = false;
                    }

                }
                else
                {
                    // Characters are not numeric, so invalidate the chequeNumber
                    result = false;
                }
            }

            return result;
        }

        public static bool ValidateDateF3(string chequeDate)
        {
            bool result = false;

            if (chequeDate != null && String.Compare(chequeDate, string.Empty) != 0)
            {
                DateTime dateCheck;

                string tmpChequeDate = chequeDate.Replace(" ", "").Trim();

                if (DateTime.TryParseExact(tmpChequeDate, "dd/MM/yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateCheck))
                {
                    // Parsing success
                    result = true;
                }
                else
                {
                    // Parsing failed
                    result = false;
                }
            }

            return result;
        }

        public static bool ValidateIBANF4(string iban)
        {
            bool result = false;

            if (iban != null && String.Compare(iban, string.Empty) != 0)
            {
                string tmpStrIBAN = iban.Replace(" ", "").Trim();

                if (tmpStrIBAN.Length == EURChequeConstants.IBANLength)
                {
                    // CheckDigits
                    EURFieldsExtractor clFieldsExtractor = new EURFieldsExtractor();
                    GRIBANFields ibanFields = clFieldsExtractor.extractIBANFields(tmpStrIBAN);


                    GRIBANValidator ibanVal = new GRIBANValidator();
                    result = ibanVal.ValidateIBAN(ibanFields);
                }
                else
                {
                    result = false;
                }
 
            }

            return result;
        }

        public static bool ValidateSpecialCharactersF5(string specialCharacters)
        {
            bool result = false;

            if (specialCharacters != null && String.Compare(specialCharacters, string.Empty) != 0)
            {
                long numericCheck = -1;

                if (long.TryParse(specialCharacters, out numericCheck))
                {
                    result = true;
                }
            }
            
            return result;
        }

        private static int CalculateChequeNumberCheckDigit(string eightDigitNumber)
        {
            int result = -1;

            char[] digits = eightDigitNumber.ToCharArray();

            int tmpTotal = 0;

            for (int i = 0; i < digits.Length ; i++)
            {
                int currentDigit = (int)char.GetNumericValue(digits[i]);

                tmpTotal += currentDigit * (9 - i);

            }

            int modulo = tmpTotal % EURChequeConstants.CheckDigitModulo;

            switch (modulo)
            {
                case 0:
                    result = 1;
                    break;
                case 1:
                    result = 0;
                    break;
                default:
                    result = EURChequeConstants.CheckDigitModulo - modulo;
                    break;
            }

            return result;
        }
    }
}
