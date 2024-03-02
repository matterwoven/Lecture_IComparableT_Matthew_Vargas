using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_IComparableT_Matthew_Vargas
{
    internal class NameSort : IComparer<Student>
    {
        public enum SortDirection { Ascending, Descending };
        public SortDirection Sorting;

        public NameSort() 
        {
            Sorting = SortDirection.Descending;
        }

        public NameSort(SortDirection sorting)
        {
            Sorting = sorting;
        }

        public int Compare(Student x, Student y) 
        {

            Sorting = SortDirection.Descending;

            if (Sorting == SortDirection.Descending)
            {

                return x.FirstName.CompareTo(y.FirstName);
                
            }
            else 
            {
                
                return x.FirstName.CompareTo(y.FirstName) * -1;
                
            }
        }
    }
}
