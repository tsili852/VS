using System;
using System.Collections.Generic;
using System.Text;

namespace Unisystems.Cheques.EUR.Model
{
    public static class EURChequeConstants
    {
        public const string OCRB_SS1 = ">";
        public const string OCRB_SS2 = "<";
        public const string OCRB_SS3 = "+";
        public const string CodelineDateFormat = "ddMMyy";
        public const int DateLength = 6;
        public const int NumberLength = 9;
        public const int IBANLength = 27;

        public const string DefaultChequeDate = "01/01/1800";
        public const double DefaultChequeAmount = -1.00d;

        public const string DefaultValidLabel = "Valid";
        public const string DefaultInvalidLabel = "Invalid";

        public const int CheckDigitModulo = 11;

        public const string CodelinePermittedCharacters = "0123456789GR<>+";
    }
}
