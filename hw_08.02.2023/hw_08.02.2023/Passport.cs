using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Documents
{
    public class Passport
    {
        private string name;
        private string surname;
        private string passportId;
        private string placeOfBirth;
        private string sex;
        private string nationality;
        DateTime birthday;
        DateTime dateOfIssue;
        DateTime dateOfExpiry;

        public string Name
        {
            get { return name; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!(value[i] >= 'a' && value[i] <= 'z') && !(value[i] >= 'A' && value[i] <= 'Z') &&
                        !(value[i] >= 'а' && value[i] <= 'я') && !(value[i] >= 'А' && value[i] <= 'Я'))
                    {
                        throw new Exception("Unaccessable name");
                    }
                }
                name = value;
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!(value[i] >= 'a' && value[i] <= 'z') && !(value[i] >= 'A' && value[i] <= 'Z') &&
                        !(value[i] >= 'а' && value[i] <= 'я') && !(value[i] >= 'А' && value[i] <= 'Я'))
                    {
                        throw new Exception("Unaccessable surname");
                    }
                }
                surname = value;
            }
        }

        public string PassportId
        {
            get { return passportId; }
            set
            {
                if (value.Length != 9)
                {
                    throw new Exception("Unaccessable passport ID length");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!(value[i] >= '0' && value[i] <= '9'))
                    {
                        throw new Exception("Unaccessable character in ID");
                    }
                }
                passportId = value;
            }
        }

        public string PlaceOfBirth { get { return placeOfBirth; } set { placeOfBirth = value; } }

        public string Sex { get { return sex; } set { sex = value; } }

        public string Nationality
        {
            get { return nationality; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!(value[i] >= 'a' && value[i] <= 'z') && !(value[i] >= 'A' && value[i] <= 'Z') &&
                        !(value[i] >= 'а' && value[i] <= 'я') && !(value[i] >= 'А' && value[i] <= 'Я'))
                    {
                        throw new Exception("Unaccessable nationality");
                    }
                }
                nationality = value;
            }
        }

        public DateTime Birthday { get { return birthday; } set { birthday = value; } }

        public DateTime DateOfIssue { get { return dateOfIssue; } set { dateOfIssue = value; } }

        public DateTime DateOfExpiry { get { return dateOfExpiry; } set { dateOfExpiry = value; } }



        public Passport(string name, string surname, string passportId, string placeOfBirth, string sex,
            string nationality, string birthday, string dateOfIssue, string dateOfExpiry)
        {
            Name = name;
            Surname = surname;
            PassportId = passportId;
            PlaceOfBirth = placeOfBirth;
            Sex = sex;
            Nationality = nationality;
            Birthday = DateTime.ParseExact(birthday, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateOfIssue = DateTime.ParseExact(dateOfIssue, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            DateOfExpiry = DateTime.ParseExact(dateOfExpiry, "dd.MM.yyyy", CultureInfo.InvariantCulture);

        }

        public override string ToString()
        {
            StringBuilder temp = new StringBuilder();
            temp.Append($"Name : {Name}\n");
            temp.Append($"Surname : {Surname}\n");
            temp.Append($"Passport Id : {PassportId}\n");
            temp.Append($"Place Of Birth : {PlaceOfBirth}\n");
            temp.Append($"Sex : {Sex}\n");
            temp.Append($"Nationality : {nationality}\n");
            temp.Append($"Birthday : {Birthday.ToString("dd.MM.yyyy")}\n");
            temp.Append($"Date Of Issue : {DateOfIssue.ToString("dd.MM.yyyy")}\n");
            temp.Append($"Date Of Expiry : {DateOfExpiry.ToString("dd.MM.yyyy")}\n");
            return temp.ToString();
        }
    }
}
