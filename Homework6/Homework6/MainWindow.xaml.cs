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

namespace Homework6
{
    class Employee
    {
        virtual public uint Salary
        {
            get
            {
                return m_salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ошибка в поле ввода зарплаты");
                }
                else
                {
                    m_salary = value;
                }
            }
        }

        virtual public byte Experience
        {
            get
            {
                return m_experience;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Ошибка в поле ввода стажа");
                }
                else
                {
                    m_experience = value;
                }
            }
        }

        public enum Department
        {
            Marketing,
            Production,
            Economical,
            Any
        }

        private uint m_salary;
        private byte m_experience;
        public Department m_department;

        public override string ToString()
        {
            string department;
            switch (m_department)
            {
                case Department.Marketing:
                    department = "отдел маркетинга";
                    break;
                case Department.Production:
                    department = "отдел разработки";
                    break;
                case Department.Economical:
                    department = "отдел бухгалтерии";
                    break;
                default:
                    department = "";
                    break;
            }
            string trainee = "";
            if (Salary == 0)
            {
                trainee = "(стажер)";
            }
            string experience;
            if (Experience < 11 || Experience > 14)
            {
                if (Experience < 10)
                {
                    switch (Experience)
                    {
                        case 0:
                            return $"Работник - зарплата {Salary}, без опыта, {department}";
                        case 1:
                            experience = "год";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что - то пошло не так";
                    }
                }
                else
                {
                    switch (Experience % 10)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 1:
                            experience = "год";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что-то пошло не так";
                    }
                }
            }
            else
            {
                experience = "лет";
            }
            return $"Работник - зарплата {Salary}{trainee}, стаж {Experience} {experience}, {department}";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Employee employee = (Employee)obj;
            return this.Salary == employee.Salary && this.Experience == employee.Experience && this.m_department == employee.m_department;
        }
    }

    class Cleaner : Employee
    {
        public override string ToString()
        {
            string department;
            switch (m_department)
            {
                case Department.Marketing:
                    department = "отдел маркетинга";
                    break;
                case Department.Production:
                    department = "отдел разработки";
                    break;
                case Department.Economical:
                    department = "отдел бухгалтерии";
                    break;
                default:
                    department = "";
                    break;
            }
            string trainee = "";
            if (Salary == 0)
            {
                trainee = "(стажер)";
            }
            string experience;
            if (Experience < 11 || Experience > 14)
            {
                if (Experience < 10)
                {
                    switch (Experience)
                    {
                        case 0:
                            return $"Уборщик - зарплата {Salary}, без опыта, {department}";
                        case 1:
                            experience = "год";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что - то пошло не так";
                    }
                }
                else
                {
                    switch (Experience % 10)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 1:
                            experience = "год";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что-то пошло не так";
                    }
                }
            }
            else
            {
                experience = "лет";
            }
            return $"Уборщик - зарплата {Salary} {trainee}, стаж {Experience} {experience}, {department}";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Cleaner cleaner = (Cleaner)obj;
            return this.Salary == cleaner.Salary && this.Experience == cleaner.Experience && this.m_department == cleaner.m_department;
        }
    }

    class Manager : Employee
    {
        public override string ToString()
        {
            string department;
            switch (m_department)
            {
                case Department.Marketing:
                    department = "отдел маркетинга";
                    break;
                case Department.Production:
                    department = "отдел разработки";
                    break;
                case Department.Economical:
                    department = "отдел бухгалтерии";
                    break;
                default:
                    department = "";
                    break;
            }
            string trainee = "";
            if (Salary == 0)
            {
                trainee = "(стажер)";
            }
            string experience;
            if (Experience < 11 || Experience > 14)
            {
                if (Experience < 10)
                {
                    switch (Experience)
                    {
                        case 0:
                            return $"Менеджер - зарплата {Salary}, без опыта, {department}";
                        case 1:
                            experience = "год";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что - то пошло не так";
                    }
                }
                else
                {
                    switch (Experience % 10)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 1:
                            experience = "год";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что-то пошло не так";
                    }
                }
            }
            else
            {
                experience = "лет";
            }
            return $"Менеджер - зарплата {Salary} {trainee}, стаж {Experience} {experience}, {department}";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Manager manager = (Manager)obj;
            return this.Salary == manager.Salary && this.Experience == manager.Experience && this.m_department == manager.m_department;
        }
    }
    class Programmer : Employee
    {
        public override string ToString()
        {
            string department;
            switch (m_department)
            {
                case Department.Marketing:
                    department = "отдел маркетинга";
                    break;
                case Department.Production:
                    department = "отдел разработки";
                    break;
                case Department.Economical:
                    department = "отдел бухгалтерии";
                    break;
                default:
                    department = "";
                    break;
            }
            string trainee = "";
            if (Salary == 0)
            {
                trainee = "(стажер)";
            }
            string experience;
            if (Experience < 11 || Experience > 14)
            {
                if (Experience < 10)
                {
                    switch (Experience)
                    {
                        case 0:
                            return $"Программист - зарплата {Salary}, без опыта, {department}";
                        case 1:
                            experience = "год";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что - то пошло не так";
                    }
                }
                else
                {
                    switch (Experience % 10)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 1:
                            experience = "год";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что-то пошло не так";
                    }
                }
            }
            else
            {
                experience = "лет";
            }
            return $"Программист - зарплата {Salary} {trainee}, стаж {Experience} {experience}, {department}";
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Programmer programmer = (Programmer)obj;
            return this.Salary == programmer.Salary && this.Experience == programmer.Experience && this.m_department == programmer.m_department;
        }
    }
    class Director : Employee
    {
        public override string ToString()
        {
            string department;
            switch (m_department)
            {
                case Department.Marketing:
                    department = "отдел маркетинга";
                    break;
                case Department.Production:
                    department = "отдел разработки";
                    break;
                case Department.Economical:
                    department = "отдел бухгалтерии";
                    break;
                default:
                    department = "";
                    break;
            }
            string trainee = "";
            if (Salary == 0)
            {
                trainee = "(стажер)";
            }
            string experience;
            if (Experience < 11 || Experience > 14)
            {
                if (Experience < 10)
                {
                    switch (Experience)
                    {
                        case 0:
                            return $"Директор - зарплата {Salary}, без опыта, {department}";
                        case 1:
                            experience = "год";
                            break;
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что - то пошло не так";
                    }
                }
                else
                {
                    switch (Experience % 10)
                    {
                        case 0:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            experience = "лет";
                            break;
                        case 1:
                            experience = "год";
                            break;
                        case 2:
                        case 3:
                        case 4:
                            experience = "года";
                            break;
                        default:
                            return $"Что-то пошло не так";
                    }
                }
            }
            else
            {
                experience = "лет";
            }
            return $"Директор - зарплата {Salary} {trainee}, стаж {Experience} {experience}, {department}";

        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            Director director = (Director)obj;
            return this.Salary == director.Salary && this.Experience == director.Experience && this.m_department == director.m_department;
        }
    }
    public partial class MainWindow : Window
    {
        List<Employee> employees = new List<Employee>()
        {
            new Cleaner() {Salary = 5000, Experience = 5, m_department = Employee.Department.Economical},
            new Cleaner() {Salary = 10000, Experience = 2, m_department = Employee.Department.Production},
            new Cleaner() {Salary = 15000, Experience = 5, m_department = Employee.Department.Marketing},
            new Manager() {Salary = 50000, Experience = 30, m_department = Employee.Department.Economical},
            new Manager() {Salary = 60000, Experience = 5, m_department = Employee.Department.Production},
            new Manager() {Salary = 70000, Experience = 1, m_department = Employee.Department.Marketing},
            new Programmer() {Salary = 2000000, Experience = 33, m_department = Employee.Department.Production},
            new Programmer() {Salary = 6000, Experience = 0, m_department = Employee.Department.Marketing},
            new Programmer() {Salary = 70, Experience = 3, m_department = Employee.Department.Economical},
            new Director() {Salary = 500000, Experience = 6, m_department = Employee.Department.Economical},
            new Director() {Salary = 60000, Experience = 11, m_department = Employee.Department.Production},
            new Director() {Salary = 7000, Experience = 2, m_department = Employee.Department.Economical},
        };

        public MainWindow()
        {
            InitializeComponent();
            updateListBox(employees);
            updateAverageExperience(employees);
        }

        void updateAverageExperience(List<Employee> employees)
        {
            int AverageExperience = 0;
            foreach (var employee in employees)
            {
                AverageExperience += employee.Experience;
            }
            AverageExperience = Convert.ToByte(AverageExperience / employees.Count);
            tbAverageExperience.Text = Convert.ToString(AverageExperience);
        }

        void updateAverageSalary(List<Employee> employees)
        {
            uint averageSalary = 0;
            foreach (var employee in employees)
            {
                averageSalary += employee.Salary;
            }
            averageSalary = Convert.ToUInt32(averageSalary / employees.Count);
            tbAverageSalary.Text = Convert.ToString(averageSalary);
        }

        void updateListBox(List<Employee> employees)
        {
            lbEmployees.Items.Clear();
            foreach (var employee in employees)
            {
                lbEmployees.Items.Add(employee);
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cbDepartment.SelectedIndex != -1 && cbPost.SelectedIndex != -1)
                {
                    switch (cbPost.SelectedIndex)
                    {
                        case 0:
                            Cleaner cleaner = new Cleaner
                            {
                                Salary = uint.Parse(tbSalary.Text),
                                Experience = byte.Parse(tbExperience.Text),
                                m_department = (Employee.Department)cbDepartment.SelectedIndex,
                            };
                            employees.Add(cleaner);
                            updateListBox(employees);
                            break;
                        case 1:
                            Manager manager = new Manager
                            {
                                Salary = uint.Parse(tbSalary.Text),
                                Experience = byte.Parse(tbExperience.Text),
                                m_department = (Employee.Department)cbDepartment.SelectedIndex,
                            };
                            employees.Add(manager);
                            updateListBox(employees);
                            break;
                        case 2:
                            Programmer programmer = new Programmer
                            {
                                Salary = uint.Parse(tbSalary.Text),
                                Experience = byte.Parse(tbExperience.Text),
                                m_department = (Employee.Department)cbDepartment.SelectedIndex,
                            };
                            employees.Add(programmer);
                            updateListBox(employees);
                            break;
                        case 3:
                            Director director = new Director
                            {
                                Salary = uint.Parse(tbSalary.Text),
                                Experience = byte.Parse(tbExperience.Text),
                                m_department = (Employee.Department)cbDepartment.SelectedIndex,
                            };
                            employees.Add(director);
                            updateListBox(employees);
                            break;
                    }
                }
                else MessageBox.Show("Выберите все свойства", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте введенные значения", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте введенные значения", "Ошибка данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            updateAverageExperience(employees);
            cbDepartment_2.SelectedIndex = 3;
            updateAverageSalary(employees);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Employee[] employeeDeleted = new Employee[lbEmployees.SelectedItems.Count];
            lbEmployees.SelectedItems.CopyTo(employeeDeleted, 0);
            foreach (var employee in employeeDeleted)
            {
                lbEmployees.Items.Remove(employee);
                employees.Remove(employee);
            }
            updateListBox(employees);
            updateAverageExperience(employees);
        }

        private void cbDepartment_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbEmployees.Items.Clear();
            List<Employee> employeesOfDepartment = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.m_department == (Employee.Department)cbDepartment_2.SelectedIndex)
                {
                    employeesOfDepartment.Add(employee);
                    updateListBox(employeesOfDepartment);
                    updateAverageSalary(employeesOfDepartment);
                }
                else if (cbDepartment_2.SelectedIndex == 3)
                {
                    updateListBox(employees);
                    updateAverageSalary(employees);
                }
            }
        }
    }
}
