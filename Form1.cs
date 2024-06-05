using System.ComponentModel;
namespace _24._05
{
    public partial class Form1 : Form
    {
        public class Employee
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        private EmployeeViewModel _viewModel;
        public Form1()
        {
            InitializeComponent();
            _viewModel = new EmployeeViewModel();
            BindControls();
        }
        private void BindControls()
        {
            nameTextBox.DataBindings.Add("Text", _viewModel, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            ageNumericUpDown.DataBindings.Add("Value", _viewModel, "Age", false, DataSourceUpdateMode.OnPropertyChanged);
            employeesDataGridView.DataSource = _viewModel.Employees;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            _viewModel.AddEmployee();
        }
        public class EmployeeViewModel : INotifyPropertyChanged
        {
            private string _name;
            private int _age;
            private BindingList<Employee> _employees;

            public event PropertyChangedEventHandler PropertyChanged;

            public EmployeeViewModel()
            {
                _employees = new BindingList<Employee>();
            }

            public string Name
            {
                get { return _name; }
                set
                {
                    if (_name != value)
                    {
                        _name = value;
                        OnPropertyChanged("Name");
                    }
                }
            }

            public int Age
            {
                get { return _age; }
                set
                {
                    if (_age != value)
                    {
                        _age = value;
                        OnPropertyChanged("Age");
                    }
                }
            }

            public BindingList<Employee> Employees
            {
                get { return _employees; }
                set
                {
                    if (_employees != value)
                    {
                        _employees = value;
                        OnPropertyChanged("Employees");
                    }
                }
            }

            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            public void AddEmployee()
            {
                var newEmployee = new Employee { Name = this.Name, Age = this.Age };
                Employees.Add(newEmployee);
            }
        }
    }
}
