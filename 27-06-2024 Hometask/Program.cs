namespace _27_06_2024_Hometask
{
    internal class Program
    {

        static void Main(string[] args)
        {
                Department department = new Department("IT", 30);
            try
            {

                Employee emp1 = new Employee("Ismayil Eliyev", 25, 50000);
                Employee emp2 = new Employee("Eli Veliyev", 35, 60000);

                department.AddEmployee(emp1);
                department.AddEmployee(emp2);


                Employee emp3 = new Employee("Aqil Agayev", 20, 70000);
                department.AddEmployee(emp3);
            }
            catch (CapacityLimitException ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (var employee in department.employees)
            {
                Console.WriteLine(employee.ShowInfo()); ;
                
            }
        }
    }
}
