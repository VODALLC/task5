using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Task5
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            txtAge.Text = "Возраст";
            txtName.Text = "Имя";
            txtAverageScore.Text = "Оценка";
            btnAddStudent.Text = "Сохранить студента";
            btnDisplayStudents.Text = "Вывести список студентов";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click_1(object sender, EventArgs e)
        {
            string name = txtName.Text;
            int age;
            double averageScore;

            // Проверка на полное имя (должно содержать хотя бы одно пробельное разделение)
            if (!name.Contains(" "))
            {
                consoleBox.AppendText("Ошибка: Имя студента должно быть полным (Фамилия Имя)." + Environment.NewLine);
                return; 
            }

            // Проверка на корректность возраста
            if (!int.TryParse(txtAge.Text, out age) || age <= 0)
            {
                consoleBox.AppendText("Ошибка: Возраст должен быть положительным числом." + Environment.NewLine);
                return;
            }

            //  (от 1 до 10)
            if (!double.TryParse(txtAverageScore.Text, out averageScore) || averageScore < 1 || averageScore > 10)
            {
                consoleBox.AppendText("Ошибка: Средний балл должен быть числом от 1 до 10." + Environment.NewLine);
                return;
            }

            Student student = new Student(name, age, averageScore);
            students.Add(student);

            consoleBox.AppendText($"Добавлен студент: {student.GetInfo()}" + Environment.NewLine);
        }

        private void btnDisplayStudents_Click_1(object sender, EventArgs e)   //вывод всех студентов
        {
            consoleBox.AppendText("Список студентов:" + Environment.NewLine);
            foreach (var student in students)
            {
                consoleBox.AppendText(student.GetInfo() + Environment.NewLine);
            }
        }
    }
    public class Student
    {
        // Свойства
        public string Name { get; set; }
        public int Age { get; set; }
        public double AverageScore { get; set; }

        // Конструктор
        public Student(string name, int age, double averageScore)
        {
            Name = name;
            Age = age;
            AverageScore = averageScore;
        }

        // Метод для вывода информации о студенте
        public string GetInfo()
        {
            return $"Имя: {Name}, Возраст: {Age}, Средний балл: {AverageScore}, Оценка: {GetGrade()}";
        }

        // Метод для оценки успеваемости
        public string GetGrade()
        {
            if (AverageScore >= 8.0)
                return "Отлично";
            else if (AverageScore >= 6.0)
                return "Хорошо";
            else if (AverageScore >= 4.0)
                return "Удовлетворительно";
            else
                return "Неудовлетворительно";
        }
    }
}
