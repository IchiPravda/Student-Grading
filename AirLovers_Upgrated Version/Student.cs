using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLovers_Upgrated_Version
{
    public class Student
    {
        //im make all student details in this class
        public string Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string DateOfStart { get; set; }

        public List<Student> GetAddstudents()
        { return myData.students; }
    }
}
