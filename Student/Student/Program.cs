using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
	class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string City { get; set; }

		public Student(){ }

		public Student(string FirstName, string LastName, int Age, string City)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Age = Age;
			this.City = City;
		}
		
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please enter I to insert a new student details or R to read the existing student details");
			string input = Console.ReadLine();
			if ((input).ToLower() == "i")
			{
				Console.WriteLine("Enter number of student records you would like to insert");
				int numOfStudent = Int32.Parse(Console.ReadLine());				
				Student[] Students = new Student[numOfStudent];


				for (int i = 0; i < numOfStudent; i++)
				{

					Students[i] = new Student();
					string FirstName = "";
					do
					{
						Console.WriteLine("Enter Student{0} First Name :", i + 1);
						FirstName = Console.ReadLine();
						if (!string.IsNullOrEmpty(FirstName))
						{
							Students[i].FirstName = FirstName;
						}
						else
						{
							Console.WriteLine("Empty input, please try again");
						}
					} while (string.IsNullOrEmpty(FirstName));

					string LastName = "";
					do
					{
						Console.WriteLine("Enter Student{0} Last Name :", i + 1);
						LastName = Console.ReadLine();
						if (!string.IsNullOrEmpty(LastName))
						{
							Students[i].LastName = LastName;
						}
						else
						{
							Console.WriteLine("Empty input, please try again");
						}
					} while (string.IsNullOrEmpty(LastName));					

					int X;
					Console.WriteLine("Enter Student{0} Age :", i+1);
					string Result = Console.ReadLine();
					while (!Int32.TryParse(Result, out X))
					{
						Console.WriteLine("Not a valid number, try again.");
						Result = Console.ReadLine();
					}
					Students[i].Age = X;
					
					string City = "";
					do
					{
						Console.WriteLine("Enter Student{0} City :", i + 1);
						City = Console.ReadLine();
						if (!string.IsNullOrEmpty(City))
						{
							Students[i].City = City;
						}
						else
						{
							Console.WriteLine("Empty input, please try again");
						}
					} while (string.IsNullOrEmpty(City));

					//Console.WriteLine("Enter Student{0} First Name :", i+1);					
					//Students[i].FirstName = Console.ReadLine();

					//Console.WriteLine("Enter Student{0} Last Name :", i+1);
					//Students[i].LastName = Console.ReadLine();

					//Console.WriteLine("Enter Student{0} City :", i + 1);
					//Students[i].City = Console.ReadLine();

				}
				Console.WriteLine("Student/Student's Details:");
				for (int i = 0; i < numOfStudent; i++)
				{					
					Console.WriteLine(Students[i].FirstName + " " +Students[i].LastName +" "+ Students[i].Age + " " +Students[i].City);
				}


			} 

			/*
			Console.WriteLine("Enter First Name :");
			string FirstName = Console.ReadLine();
			Console.WriteLine("Enter Last Name :");
			string LastName = Console.ReadLine();
			Console.WriteLine("Enter Age:");
			string Age = Console.ReadLine();
			Console.WriteLine("Enter City:");
			string City = Console.ReadLine();
			Console.WriteLine("Student Details:");
			Console.WriteLine(FirstName + " " + LastName + " " +Age + " " + City);


			 Console.WriteLine("Enter student First name, Last name, Age, City seperated by commas EX: Sandeep,Nalla,26,Dallas");
			string input1 = Console.ReadLine();				
			string[] listsplit = input1.Split(',');
			foreach (string inp in listsplit)
			{
				Console.Write(inp);
			}
			*/
		
			else if (input.ToLower() == "r")
			{
				Student student1 = new Student("Sandeep","Nalla",26,"Houston");
				Student student2 = new Student("Chandra","Reddy",25,"Fremont");
				Student student3 = new Student("Ravi","Kiran",27,"Miami");				

				Console.WriteLine("Student Details:");
				Console.WriteLine(student1.FirstName + " " + student1.LastName + " " + student1.Age + " " + student1.City);
				Console.WriteLine(student2.FirstName + " " + student2.LastName + " " + student2.Age + " " + student2.City);
				Console.WriteLine(student3.FirstName + " " + student3.LastName + " " + student3.Age + " " + student3.City);
			}
			else
			{
				Console.WriteLine("Incorrect input");
			}
			Console.ReadKey();

		}
	}
}
