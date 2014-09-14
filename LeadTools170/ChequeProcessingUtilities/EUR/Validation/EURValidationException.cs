using System;
using System.Collections.Generic;
using System.Text;

namespace Unisystems.Cheques.EUR.Validation
{
    class EURValidationException : Exception
    {

        private String  _errorMessage;
        public String  ErrorMessage
        {
            get { return _errorMessage; }
            set { _errorMessage = value; }
        }


        public EURValidationException(String errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
