using System;
using System.Collections.Generic;
using System.Text;

namespace Unisystems.Cheques.EUR.Model
{
    public class EURCodelineFields
    {

        private double _Amount;
        public double Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        private string _ChequeNo;
        public string ChequeNo
        {
            get { return _ChequeNo; }
            set { _ChequeNo = value; }
        }

        private DateTime _ChequeDate;
        public DateTime ChequeDate
        {
            get { return _ChequeDate; }
            set { _ChequeDate = value; }
        }

        private String _IBAN;
        public String IBAN
        {
            get { return _IBAN; }
            set { _IBAN = value; }
        }

        private String _SpecialCharacters;
        public String SpecialCharacters
        {
            get { return _SpecialCharacters; }
            set { _SpecialCharacters = value; }
        }
    }
}
