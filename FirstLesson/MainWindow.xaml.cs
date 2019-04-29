using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstLesson
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        Student student = new Student();
        private void buttonCreate_Click(object sender, RoutedEventArgs e)
        {
             student = new Student
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                YearBirth = int.Parse(textBoxYear.Text),
                MonthBirth = int.Parse(textBoxMonth.Text),
                DayBirth = int.Parse(textBoxDay.Text),
                Course = int.Parse(textBoxCourse.Text),
                Group = textBoxGroup.Text
            };

            
        }

        private void buttonShow_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Студент: \n" +
          "Имя: " + student.Name + "\n" +
         "Дата рождения: " + student.DayBirth + "/" + student.MonthBirth + "/" + student.YearBirth + "\n" +
         "Курс: " + student.Course + "\n" +
          "Группа: " + student.Group);
        }

       
    }
}
