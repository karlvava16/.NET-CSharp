using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class City
    {
        private string cityName;
        private string countryName;
        private string phoneCode;
        private int citizens;
        string[] cityAreas;

        public string CityName { get { return cityName;} set { cityName = value; } }    
        public string CountryName { get { return countryName;} set { countryName = value; } }  
        public string PhoneCode { get { return phoneCode;} set { phoneCode = value; } }
        public int Citizens { get { return citizens;} set { citizens = value; } }  
        public string[] CityAreas { get { return cityAreas;} set { cityAreas = value; } }

        public City() 
        {
            CityName = null;
            CountryName = null;
            PhoneCode = null;
            Citizens = 0;
            CityAreas = null;
        }  

        public City(string cityName) : this()
        {
            CityName = cityName;
        }

        public City(string cityName, string countryName) : this(cityName)
        {
            CountryName = countryName;
        }

        public City(string cityName, string countryName, string phoneCode) : this(cityName, countryName)
        {
            PhoneCode = phoneCode;
        }

        public City(string cityName, string countryName, string phoneCode, int citizens) : this(cityName, countryName, phoneCode)
        {
            Citizens = citizens;
        }

        public City(string cityName, string countryName, string phoneCode, int citizens, string[] cityAreas) : this(cityName, countryName, phoneCode, citizens)
        {
           CityAreas = cityAreas;
        }

        public static City operator +(City a, int people)
        {
            var b = a;
            b.Citizens += people;
            return b;
        }
        public static City operator +(int people, City a)
        {
            var b = a;
            b.Citizens = people + a.Citizens;
            return b;
        }

        public static City operator -(City a, int people)
        {
            var b = a;
            b.Citizens -= people;
            return b;
        }
        public static City operator -(int people, City a)
        {
            var b = a;
            b.Citizens = people - a.Citizens;
            return b;
        }

        public static bool operator <(City a, City b)
        {
            return a.Citizens < b.Citizens;
        }
        public static bool operator >(City a, City b)
        {
            return a.Citizens > b.Citizens;
        }

        public static bool operator ==(City a, City b)
        {
            return a.Citizens == b.Citizens;
        }

        public static bool operator !=(City a, City b)
        {
            return a.Citizens != b.Citizens;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"City : {CityName}\n");
            sb.Append($"Country : {CountryName}\n");
            sb.Append($"PhoneCode : {PhoneCode}\n");
            sb.Append($"Citizens : {Citizens}\n");
            sb.Append("Areas : \n");
            foreach (var cityArea in CityAreas) 
                sb.Append($"{cityArea}\n");

            return sb.ToString();
        }

    }
}
