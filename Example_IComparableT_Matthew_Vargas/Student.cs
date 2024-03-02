using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Example_IComparableT_Matthew_Vargas
{
    class Student : IComparable<Student>
    { 
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            Random random = new Random();


            FirstName = firstName;
            LastName = lastName;
            csiGrade = random.Next(100);
            genEdGrade = random.Next(100);
            CsiGrade = csiGrade;
            GenEdGrade = genEdGrade;


        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        public int CompareTo(Student? other)
        {
            //How to organize the list

            ////Ascending
            //if (this._genEdGrade > other._genEdGrade) return 1;
            //else if (this._genEdGrade < other._genEdGrade) return -1;
            //else return 0;
            ////Descending
            //if (this._genEdGrade < other._genEdGrade) return 1;
            //else if (this._genEdGrade > other._genEdGrade) return -1;
            //else return 0;
            ////SortAlphabet
            //
            return FirstName.CompareTo(other._firstName);



        }

        //ToString below applying above values to display message

        public override string ToString()
        {
            return ($"{FirstName} {LastName}  |  Grades - GenEd: {GenEdGrade}, CSI: {CsiGrade}");
        }
    }
}
