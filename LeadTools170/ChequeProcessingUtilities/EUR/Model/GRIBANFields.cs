using System;
using System.Collections.Generic;
using System.Text;

namespace Unisystems.Cheques.EUR.Model
{
    public class GRIBANFields
    {
        private string _CountryCode;
        public string CountryCode
        {
            get { return _CountryCode; }
            set { _CountryCode = value; }
        }

        private string _CheckDigits;
        public string CheckDigits
        {
            get { return _CheckDigits; }
            set { _CheckDigits = value; }
        }

        private string _BankCode;
        public string BankCode
        {
            get { return _BankCode; }
            set { _BankCode = value; }
        }

        private string _BranchCode;
        public string BranchCode
        {
            get { return _BranchCode; }
            set { _BranchCode = value; }
        }

        private string _AccountNumber;
        public string AccountNumber
        {
            get { return _AccountNumber; }
            set { _AccountNumber = value; }
        }

        public string HEBIC
        {
            get { return String.Concat(new string[] {_BankCode, _BranchCode}); }
        }

        public string BBAN
        {
            get { return String.Concat(new string[] { _BankCode, _BranchCode, _AccountNumber}); }
        }


    }
}
