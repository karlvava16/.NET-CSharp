using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Passport
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Sex { get; set; }
        public string Nationality { get; set; }

        public string DateOfIssue { get; set; }
        public string DateOfExpiry { get; set; }

        public string DateOfBirth { get; set; }

        public string Authority { get; set; }

        public string PlaceOfBirth { get; set; }

        public Passport(string name, string surname, string sex, string nationality, string dateOfIssue, string dateOfExpiry, string dateOfBirth, string authority, string placeOfBirth)
        {
            Name = name;
            Surname = surname;
            Sex = sex;
            Nationality = nationality;
            DateOfIssue = dateOfIssue;
            DateOfExpiry = dateOfExpiry;
            Authority = authority;
            PlaceOfBirth = placeOfBirth;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}\n");
            sb.Append($"Surname: {Surname}\n");
            sb.Append($"Sex: {Sex}\n");
            sb.Append($"Nationality: {Nationality}\n");
            sb.Append($"Date Of Issue: {DateOfIssue}\n");
            sb.Append($"Date Of Expiry: {DateOfExpiry}\n");
            sb.Append($"Date Of Birth: {DateOfBirth}\n");
            sb.Append($"Authority: {Authority}\n");
            sb.Append($"Place Off Birth: {PlaceOfBirth}\n");

            return sb.ToString();
        }
    }
}
