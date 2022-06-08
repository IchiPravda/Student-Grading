using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirLovers_Upgrated_Version
{
    internal class Grade
        //this class obtain all data about grade form
    {
        public double attendance; //out of 20
        public double project1;//out of 20
        public double project2;//out of 20
        public double project3;//out of 20
        public double project4;//out of 40
        public double finalexam;//out off 100

        //calculation Grade
        public double Attendance()//for calculating all attendance is 10%
        {
            double hadir;
            hadir = attendance / 2;
            return hadir;
        }
        public double project()//for calculating all Project is 50%
        {
            double projectfn;
            projectfn = (project1 + project2 + project3 + project4) / 2;
            return projectfn;
        }

        public double FinalExam()//for calculating final is 40%
        {
            double exam;
            exam = finalexam / 2.5;
            return exam;
        }

        public double FinalExam2()//for calculating all score out of 5
        {
            double exam2;
            exam2 = (FinalExam() + project() + Attendance()) / 20;
            return exam2;
        }
        public double FinalExam3()//for calculating all score out of 100
        {
            double exam3;
            exam3 = FinalExam() + project() + Attendance();
            return exam3;
        }
    }
}
