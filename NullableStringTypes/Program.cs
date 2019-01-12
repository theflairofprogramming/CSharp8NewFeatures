using static System.Console;

namespace NullableStringTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("John", "Snow");

            if(customer.MiddleName?.Length > 0) 
            {
                WriteLine($"Customer Name: {customer.FirstName} {customer.MiddleName} {customer.LastName}");
            }
            else
            {
                WriteLine($"Customer Name: {customer.FirstName} {customer.LastName}");
            }

            Customer[] customers = new Customer[10];

            WriteLine($"Customers List");

            for (int i = 0; i < 10; i++)
            {
                if (customers[i].MiddleName?.Length > 0)
                {
                    WriteLine($"{i.ToString()}. {customers[i].FirstName} {customers[i].MiddleName} {customers[i].LastName}");
                }
                else
                {
                    WriteLine($"{i.ToString()}. {customers[i].FirstName} {customers[i].LastName}");
                }
            }

            ReadLine();
        }
    }

    class Customer
    {
        public string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string LastName { get; set; }

        public Customer(string firstName, string lastName, string? middleName = null)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
        }

    }
}
