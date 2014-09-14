using System;
using System.Collections.Generic;
using System.Text;
using Unisystems.Cheques.EUR.Model;

namespace Unisystems.Cheques.EUR.Validation
{
    public class GRIBANValidator
    {
        public const string GRCountryCodeValue = "GR";
        public const string GRCountryCodeSubstitution = "1627";

        public const int CountryCodeStartingIndex = 0;
        public const int CountryCodeLength = 2;

        public const int CheckDigitsStartingIndex = 2;
        public const int CheckDigitsLength = 2;

        public const int CheckDigitModulo = 97;

        public const int BankCodeStartingIndex = 4;
        public const int BankCodeLength = 3;

        public const int BranchCodeStartingIndex = 7;
        public const int BranchCodeLength = 4;

        public const int AccountNumberStartingIndex = 11;
        public const int AccountNumberLength = 16;

        public bool ValidateCountryCode(string countryCode)
        {
            bool result = false;

            if (String.Compare(countryCode, GRIBANValidator.GRCountryCodeValue) == 0)
                result = true;

            return result;
        }

        public bool ValidateIBAN(GRIBANFields fields)
        {
            bool result = false;

            if (ValidateCountryCode(fields.CountryCode))
            {
                string tmpIBAN = String.Concat(new string[] { fields.HEBIC, fields.AccountNumber, GRIBANValidator.GRCountryCodeSubstitution, fields.CheckDigits });

                string firstPart = tmpIBAN.Substring(0, 9);
                string secondPart = tmpIBAN.Substring(9);

                long a = -1;

                if (long.TryParse(firstPart, out a))
                {
                    long mod01 = a % GRIBANValidator.CheckDigitModulo;

                    secondPart = String.Concat(new string[] { mod01.ToString(), secondPart });
                    string thirdPart = secondPart.Substring(9);

                    long b = -1;

                    if (long.TryParse(secondPart.Substring(0, 9), out b))
                    {
                        long mod02 = b % GRIBANValidator.CheckDigitModulo;

                        thirdPart = String.Concat(new string[] { mod02.ToString(), thirdPart });
                        string fourthPart = thirdPart.Substring(9);

                        long c = -1;

                        if (long.TryParse(thirdPart.Substring(0, 9), out c))
                        {
                            long mod03 = c % GRIBANValidator.CheckDigitModulo;

                            fourthPart = String.Concat(new string[] { mod03.ToString(), fourthPart });

                            long d = -1;

                            if (long.TryParse(fourthPart, out d))
                            {
                                long mod04 = d % GRIBANValidator.CheckDigitModulo;

                                if (mod04 == 1)
                                    result = true;
                            }

                        }
                    }
                }
            }
            else
            {
                result = false;
            }

            return result;
        }
    }
}
