using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using nsPerson;

namespace nsEI
{


    abstract class EducationalInstitution
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public EducationalInstitution() { }
        public EducationalInstitution(string name, string address)
        {
            Name = name;
            Address = address;
        }
    }

    class Group
    {
        public string Name { get; set; }
        public List<Person> people;

        public List<Person> People { get { return people; } set { people = value; } }

        public Group() { people = new List<Person>(); }
        public Group(string name) : this() { Name = name; }

        public Group(string name, params Person[] people) : this(name)
        {
            People = new List<Person>(people);
        }


    }


    class Faculty
    {
        public int FacultyNum { get; set; }
        public string FacultyName { get; set; }
        public string FaclutyDescrpt { get; set; }

        public Faculty() { }
        public Faculty(int facultyNum, string facultyName, string faclutyDescrpt)
        {
            FacultyNum = facultyNum;
            FacultyName = facultyName;
            FaclutyDescrpt = faclutyDescrpt;
        }
        public override string ToString()
        {
            return $"|{FacultyNum} {FacultyName}|\nNumber : {FacultyNum}\nName : {FacultyName}\nDescription : \n{FaclutyDescrpt}\n";
        }
    }

    class University : EducationalInstitution
    {
        List<Faculty> faculties = new List<Faculty>();
        public List<Faculty> Faculties { get { return faculties; } set { faculties = value; } }

        public List<Group> 
    }

}
