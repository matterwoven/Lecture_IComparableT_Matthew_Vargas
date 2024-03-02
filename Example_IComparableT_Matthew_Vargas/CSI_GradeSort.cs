using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_IComparableT_Matthew_Vargas
{
        internal class CSI_GradeSort : IComparer<Student>
        {
            public enum Order { Ascending, Descending }
            public Order CSISort = Order.Ascending;

            public CSI_GradeSort()
            {
                CSISort = Order.Descending;
            }

            public CSI_GradeSort(Order sorting)
            {
                CSISort = sorting;
            }

            public int Compare(Student x, Student y)
            {
                if (CSISort == Order.Descending)
                {
                    if (x.CsiGrade < y.CsiGrade) return -1;
                    else if (x.CsiGrade > y.CsiGrade) return 1;
                    else return 0;
                }
                else
                {
                    if (x.CsiGrade > y.CsiGrade) return -1;
                    else if (x.CsiGrade < y.CsiGrade) return 1;
                    else return 0;
                }
            }
        }
    }

