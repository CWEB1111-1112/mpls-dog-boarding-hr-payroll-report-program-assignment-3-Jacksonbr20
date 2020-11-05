using System;
/**
Name: Brant Jackson
Date of completion:

Construct a program that allows the end-user to input each employee’s name, department number, hourly salary, and number of hours worked. 
Within each iteration of entering employee information, display the employee’s name, gross salary and department name.  
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
            double salary, hourly;
            string [] departments = {"personnel", "marketing", "information technology", "computer service", "sales", "legal", "accounting"};
            // Trigger
            Console.WriteLine("Please enter department ID (0-personnel, 1-marketing, 2-infromation technology, 3-computer service, 4-sales, 5-legal, 6-accounting)");
            Console.WriteLine("9 to quit");
            int dptID = Convert.ToInt32(Console.ReadLine());
            // multidimensional arrays
            // double [,] dptSalaries = {dptID, salary};

            // int [] personnelSalary, marketingSalary, infoTechSalary, compServiceSalary, salesSalary, legalSalary, acountingSalary;
            // string [] personnelNames, marketingNames, infoTechNames, compServiceName, salesName, legalName, accountingName;


            int END = 9;
            
            while(dptID != END){
                // Defensive Programming
                while(dptID > 6 && dptID != 9){
                    Console.WriteLine("Incorrect, please enter department ID");
                    dptID = Convert.ToInt32(Console.ReadLine());
                }

                if(dptID < 7){
                Console.WriteLine("Please enter name:");
                name = Console.ReadLine();
                Console.WriteLine("Please enter hourly salary:");
                hourly = Convert.ToDouble(Console.ReadLine());
                salary = 52 * 40 * hourly;
                Console.WriteLine("Name: " + name + " department: " + departments[dptID] + " salary: " + salary);

                    if(dptID == 0){
                        personnelNames [];
                        personnelSalary [];
                    }
                    if(dptID == 1){
                        marketingNames [];
                        marketingSalary [];
                    }
                    if(dptID == 2){
                        infoTechNames [];
                        infoTechSalary [];
                    }
                    if(dptID == 3){
                        compServiceName [];
                        compServiceSalary [];
                    }
                    if(dptID == 4){
                        salesName [];
                        salesSalary [];
                    }
                    if(dptID == 5){
                        legalName [];
                        legalSalary [];
                    }
                    if(dptID == 6){
                        accountingName [];
                        acountingSalary [];
                    }
                }

                Console.WriteLine("Please enter department ID");
                dptID = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("goodbye");
        }
    }
}
