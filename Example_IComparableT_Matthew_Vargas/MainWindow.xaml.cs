using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Example_IComparableT_Matthew_Vargas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();

        Student Matthew = new Student("Matthew", "Vargas", 0, 0);
        Student Susan = new Student("Susan", "Rogan", 0, 0);
        Student Raphael = new Student("Raphael", "Grandlon", 0, 0);
        Student Cran = new Student("Cranberry", "Grandle", 0, 0);
        Student Marcy = new Student("Marcy", "Goodwick", 0, 0);



        public MainWindow()
        {
            InitializeComponent();
            PreLoad();
            LoadStudents();

            NameSort nameSortAsc = new NameSort(NameSort.SortDirection.Ascending);
            NameSort nameSortDesc = new NameSort(NameSort.SortDirection.Descending);
            GenEd_Sort genEdSortAsc = new GenEd_Sort(GenEd_Sort.Order.Ascending);
            GenEd_Sort genEdSortDesc = new GenEd_Sort(GenEd_Sort.Order.Descending);
            CSI_GradeSort csiSortAsc = new CSI_GradeSort(CSI_GradeSort.Order.Ascending);
            CSI_GradeSort csiSortDesc = new CSI_GradeSort(CSI_GradeSort.Order.Descending);
        }

        public void PreLoad() 
        {

            students.Add(Matthew); students.Add(Susan); students.Add(Raphael); students.Add(Cran); students.Add(Marcy);   
            
        }

        public void LoadStudents()
        {
            ListOfNames.Items.Clear();

            foreach (Student student in students)
            {
                ListOfNames.Items.Add(student);

            }
        }

        private void SCIDescending_Click(object sender, RoutedEventArgs e)
        {
            CSI_GradeSort csiSortDesc = new CSI_GradeSort();
            students.Sort(csiSortDesc);
            LoadStudents();
        }

        private void CSIAscending_Click(object sender, RoutedEventArgs e)
        {
            CSI_GradeSort csiSortAsc = new CSI_GradeSort();
            students.Sort(csiSortAsc);
            LoadStudents();
        }

        //private void GenEdDescending_Click(object sender, RoutedEventArgs e)
        //{
        //    GenEd_Sort genEdSortDesc = new GenEd_Sort();
        //    students.Sort(genEdSortDesc);
        //    LoadStudents();
        //}

        private void GenEdAscending_Click(object sender, RoutedEventArgs e)
        {
            GenEd_Sort genEdSortAsc = new GenEd_Sort();
            students.Sort(genEdSortAsc);
            LoadStudents();
        }

        //private void NameDescending_Click(object sender, RoutedEventArgs e)
        //{
        //    NameSort nameSortDesc = new NameSort();
        //    students.Sort(nameSortDesc);
        //    LoadStudents();
        //}

        private void NameAscending_Click(object sender, RoutedEventArgs e)
        {
            NameSort nameSortAsc = new NameSort();
            students.Sort(nameSortAsc);
            LoadStudents();
        }
        //} //---- for later with IComparable<T> ----
    }
}