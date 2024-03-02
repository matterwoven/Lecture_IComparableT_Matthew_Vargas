using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_IComparableT_Matthew_Vargas
{
    internal class GenEd_Sort : IComparer<Student>
    {
        public enum Order { Ascending, Descending }
        public Order GenEdSort = Order.Ascending;

        public GenEd_Sort() 
        {
            GenEdSort = Order.Descending;
        }

        public GenEd_Sort(Order sorting) 
        {
            GenEdSort = sorting;
        }

        public int Compare(Student x, Student y) 
        {
            if (GenEdSort == Order.Descending)
            {
                if (x.GenEdGrade < y.GenEdGrade) return -1;
                else if (x.GenEdGrade > y.GenEdGrade) return 1;
                else return 0;
            }
            else
            {
                if (x.GenEdGrade > y.GenEdGrade) return -1;
                else if (x.GenEdGrade < y.GenEdGrade) return 1;
                else return 0;
            }
        }
    }
}
