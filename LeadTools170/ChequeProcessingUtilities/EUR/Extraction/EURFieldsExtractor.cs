using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Unisystems.Cheques.EUR;
using Unisystems.Cheques.EUR.Model;
using Unisystems.Cheques.EUR.Validation;

namespace Unisystems.Cheques.EUR.Extraction
{
    public class EURFieldsExtractor
    {
        private string _codeline;
        public string Codeline
        {
            set { _codeline = value; }
        }

        private string _tmpCodeline;
        public EURCodelineFields CodelineFields;
        public GRIBANFields IBANFields;


        public EURFieldsExtractor()
        {
            CodelineFields = new EURCodelineFields();
        }

        public string ExtractCodeline(string txtToFindCodeline)
        {
            string result = string.Empty;

            if (txtToFindCodeline != null && String.Compare(txtToFindCodeline.Trim(), string.Empty) != 0)
            {
                if (txtToFindCodeline != Environment.NewLine && !txtToFindCodeline.Trim().Equals(""))
                {
                    string[] txtLines = txtToFindCodeline.Split(Environment.NewLine.ToCharArray());

                    result = txtLines[txtLines.Length - 1];

                    for (int i = txtLines.Length - 1; i > -1; i--)
                    {
                        if (!txtLines[i].Equals(""))
                        {
                            result = txtLines[i];
                            break;
                        }
                    }
                }
            }

            return result;
        }

        public void ExtractFields(string codeline)
        {
            Codeline = codeline;

            _tmpCodeline = String.Copy(_codeline.Trim().Replace(" ", ""));

            CodelineFields.Amount = extractChequeAmountF1();
            CodelineFields.ChequeNo = extractChequeNumberF2();
            CodelineFields.ChequeDate = extractChequeDateF3();
            CodelineFields.IBAN = extractChequeIBANF4();
            CodelineFields.SpecialCharacters = extractChequeSpecialCharactersF5();

            IBANFields = extractIBANFields(CodelineFields.IBAN);
        }

        public GRIBANFields extractIBANFields(string iban)
        {
            GRIBANFields result = new GRIBANFields();

            if (iban != null)
            {
                result.CountryCode = iban.Substring(GRIBANValidator.CountryCodeStartingIndex, GRIBANValidator.CountryCodeLength);
                result.CheckDigits = iban.Substring(GRIBANValidator.CheckDigitsStartingIndex, GRIBANValidator.CheckDigitsLength);
                result.BankCode = iban.Substring(GRIBANValidator.BankCodeStartingIndex, GRIBANValidator.BankCodeLength);
                result.BranchCode = iban.Substring(GRIBANValidator.BranchCodeStartingIndex, GRIBANValidator.BranchCodeLength);
                result.AccountNumber = iban.Substring(GRIBANValidator.AccountNumberStartingIndex, GRIBANValidator.AccountNumberLength);
            }

            
            return result;
        }

        private double extractChequeAmountF1()
        {
            double result = EURChequeConstants.DefaultChequeAmount;

            if (_tmpCodeline.EndsWith(EURChequeConstants.OCRB_SS1))
            {
                // Ends with > proceeding
                // Check full codeline for F1 (amount) part

                int amtStartIndex = (_tmpCodeline.Substring(0, _tmpCodeline.Length - 2)).LastIndexOf(EURChequeConstants.OCRB_SS1);

                string tmpAmt = _tmpCodeline.Substring(amtStartIndex);

                _tmpCodeline = String.Copy(_tmpCodeline.Substring(0, _tmpCodeline.Length - tmpAmt.Length));

                string clearTmpAmt = tmpAmt.Substring(1, tmpAmt.Length - 2).Replace(" ","").Trim();

                long chkAmt = 0;

                if (long.TryParse(clearTmpAmt, out chkAmt))
                {
                    // Is Numeric
                    string formatted =
                        clearTmpAmt.Substring(0, clearTmpAmt.Length - 2) +
                        NumberFormatInfo.CurrentInfo.CurrencyDecimalSeparator +
                        clearTmpAmt.Substring(clearTmpAmt.Length - 2);
                
                        result = Convert.ToDouble(formatted);

                }
            }

            return result;
        }

        private string extractChequeNumberF2()
        {
            string result = null;


            if (_tmpCodeline.EndsWith(EURChequeConstants.OCRB_SS3))
            {
                // Ends with a + sign, proceed

                int chequeNoStartIndex = (_tmpCodeline.Substring(0, _tmpCodeline.Length - 2)).LastIndexOf(EURChequeConstants.OCRB_SS2);

                if (chequeNoStartIndex >= -1)
                {
                    string tmpNumber = _tmpCodeline.Substring(chequeNoStartIndex);

                    _tmpCodeline = String.Copy(_tmpCodeline.Substring(0, _tmpCodeline.Length - tmpNumber.Length + 1));

                    string clearTmpNum = tmpNumber.Substring(1, tmpNumber.Length - 2).Replace(" ", "").Trim();

                    long chkNum = 0;

                    if (long.TryParse(clearTmpNum, out chkNum))
                    {
                        // Is Numeric
                        result = String.Copy(clearTmpNum);
                    }

                }
                else
                {
 
                }
            }

            return result;
        }

        private DateTime extractChequeDateF3()
        {
            DateTime result = DateTime.Parse(EURChequeConstants.DefaultChequeDate, CultureInfo.CurrentCulture);

            if (_tmpCodeline.EndsWith(EURChequeConstants.OCRB_SS2))
            {

                int dateStartIndex = (_tmpCodeline.Substring(0, _tmpCodeline.Length - 2)).LastIndexOf(EURChequeConstants.OCRB_SS1);

                if (dateStartIndex > -1)
                {
                    string tmpDate = _tmpCodeline.Substring(dateStartIndex);

                    _tmpCodeline = String.Copy(_tmpCodeline.Substring(0, _tmpCodeline.Length - tmpDate.Length + 1));

                    string clearTmpDate = tmpDate.Substring(1, tmpDate.Length - 2).Replace(" ", "").Trim();


                    if (clearTmpDate.Length == EURChequeConstants.DateLength)
                    {
                        if (DateTime.TryParseExact(clearTmpDate, EURChequeConstants.CodelineDateFormat, CultureInfo.CurrentCulture, DateTimeStyles.None, out result))
                        {
                            // Parsing success
                        }
                    }
                }
                else
                {
                    _tmpCodeline = String.Copy(_tmpCodeline.Substring(0, _tmpCodeline.Length - 1));
                }
            }
            
            return result;
            
        }

        private string extractChequeIBANF4()
        {
            string result = null;


            if (_tmpCodeline.EndsWith(EURChequeConstants.OCRB_SS1))
            {
                // Ends with a + sign, proceed

                int ibanStartIndex = (_tmpCodeline.Substring(0, _tmpCodeline.Length - 2)).LastIndexOf(EURChequeConstants.OCRB_SS2);

                if (ibanStartIndex > -1)
                {
                    string tmpIBAN = _tmpCodeline.Substring(ibanStartIndex);

                    _tmpCodeline = String.Copy(_tmpCodeline.Substring(0, _tmpCodeline.Length - tmpIBAN.Length + 1));

                    string clearIBAN = tmpIBAN.Substring(1, tmpIBAN.Length - 2).Replace(" ", "").Trim();

                    result = String.Copy(clearIBAN);
                }
            }

            return result;
        }

        private string extractChequeSpecialCharactersF5()
        {
            string result = null;

            if (_tmpCodeline.StartsWith(EURChequeConstants.OCRB_SS3) && _tmpCodeline.EndsWith(EURChequeConstants.OCRB_SS2))
            {

                result = _tmpCodeline.Substring(1, _tmpCodeline.Length - 2);
                
            }

            return result;
        }
    }
}
