namespace _27_06_2024_Hometask
{
    public class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public Employee[] employees;

        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            if (employees.Length >= EmployeeLimit)
            {
                throw new CapacityLimitException("Employee limit exceeded.");
            }

            Array.Resize(ref employees,employees.Length+1);
            employees[^1] = employee;
        }

        public Employee this[int index]
        {
            get
            {
                if (index >= 0 && index < employees.Length)
                {
                    return employees[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Yanlış indeks.");
                }
            }
            set
            {
                if (index >= 0 && index < employees.Length)
                {
                    employees[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Yanlış indeks.");
                }
            }
        }
    }

}
