using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEnrollmentSystem1
{
    class Student
    {
        public string RegNum { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string ContNo { get; set; }
        public string ECourse { get; set; }


        public Student(string regNum, string name, string dob,string age,string gender, string contNo,  string ecourse)
        {
            RegNum = regNum;
            Name = name;
            DOB = dob;
            Age = age;
            Gender = gender;
            ContNo = contNo;
            ECourse = ecourse;
            

        }
    }
}
