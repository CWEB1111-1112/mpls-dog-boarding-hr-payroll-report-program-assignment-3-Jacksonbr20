using System;
/**
Name: Brant Jackson
Date of completion:

Construct a program that allows the end-user to input each employee’s name, department number, hourly salary, and number of hours worked. 
Your program will need to defensively program to ensure that a correct department number is entered. 
Declare an array that will hold the accumulated salary for each department and declare an array that holds each of the Department names. 
Once the end-user concludes entering employee data, you will need to output is a list of the seven departments in the company and the total gross payroll (rate times hours) for each department. 
The department names are shown in the table below.
 */
namespace assignment_three
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            double salary, hours;
            string [] departments = {"Personnel", "Marketing", "Information Technology", "Computer Service", "Sales", "Legal", "Accounting"};
            double [] dptSalary = {0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0};
            // Trigger
            Console.WriteLine("Please enter department ID (0-personnel, 1-marketing, 2-infromation technology, 3-computer service, 4-sales, 5-legal, 6-accounting)");
            Console.WriteLine("9 to quit");
            int dptID = Convert.ToInt32(Console.ReadLine());

            int SENTINEL = 9;
            
            while(dptID != SENTINEL){
                // Defensive Programming
                while(dptID > 6 && dptID != 9){
                    Console.WriteLine("Incorrect, please enter department ID");
                    dptID = Convert.ToInt32(Console.ReadLine());
                }

                if(dptID < 7){
                    Console.WriteLine("Please enter name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Please enter hours worked:");
                    hours = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter hourly wage:");
                    salary = Convert.ToDouble(Console.ReadLine());
                    // Within each iteration of entering employee information, display the employee’s name, gross salary and department name.  
                    Console.WriteLine(departments[dptID] + "Department member " + name + " earned $" + salary * hours);
                    dptSalary[dptID] += salary * hours;
                }
      
                Console.WriteLine("Please enter department ID");
                dptID = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < 7; i++){
            Console.WriteLine(departments[i] + " Department's total gross salary is " + dptSalary[i]);
            }
        }
    }
}
