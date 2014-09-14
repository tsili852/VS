using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Unisystems.Cheques;
using Unisystems.Cheques.EUR.Model;
using Unisystems.Cheques.EUR.Extraction;
using Unisystems.Cheques.EUR.Validation;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {

            String codeline = "+   1<GR1601101250000000012300695>310810<001719017+ > 259577     >";
            EURFieldsExtractor fe = new EURFieldsExtractor();
            fe.ExtractFields(codeline);
            EURCodelineFields f = fe.CodelineFields;

            GRIBANFields ibf = fe.IBANFields;

            GRIBANValidator ibanVal = new GRIBANValidator();

            ibanVal.ValidateIBAN(ibf);

            Console.Out.WriteLine(f);

        }
    }
}
