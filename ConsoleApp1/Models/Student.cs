using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    internal class Student
    {
        private static int _pId = 1000;
        private static int _dId = 1000;

        private static int _id;
        public int Id { get; }
        public string Fullname { get; set; }
        public string Subjectname { get; set; }
        private string _groupname;
        public string Groupname
        {
            get
            {
                return _groupname;
            }
        }

        public Student(string subjectName)
        {
            _id++;
            Id = _id;
            Subjectname = subjectName;
            if(subjectName == "Programming")
            {
                _pId++;
                _groupname = Subjectname.Substring(0, 2).ToUpper() + _pId;
            } else if (subjectName == "Design")
            {
                _dId++;
                _groupname = Subjectname.Substring(0, 2).ToUpper() + _dId;
            }
        }
    }
}
