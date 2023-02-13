using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ForeignPassport : Passport
    {
        public string Type { get; set; }
        public string CountryCode { get; set; }

        public ForeignPassport(string name, string surname, string sex, string nationality, string dateOfIssue, string dateOfExpiry,
            string dateOfBirth, string authority, string placeOfBirth, string type, string countryCode) 
            : base( name,  surname,  sex,  nationality,  dateOfIssue,  dateOfExpiry,
             dateOfBirth,  authority,  placeOfBirth)
        {
            Type = type;
            CountryCode = countryCode;
        }

        public override string ToString()
        {
            return base.ToString() + $"Type: {Type}\nCountry Code: {CountryCode}";
        }
    }
}
