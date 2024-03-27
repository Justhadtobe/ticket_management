using System;
using System.Collections.Generic;
class Program
{
 static List<string> student = new List<string>();
 static List<string> studentService = new List<string>();
 static List<int> ticket = new List<int>();
 public static void Main(String[] args)
 {
 
 int option;
 do
 {
 
 Console.WriteLine("\nTicket Management Service\n");
 //Allow the user to input the name of the student and the service they require. 
 string name;
 string service;
 Console.WriteLine("Enter name:");
 name = Console.ReadLine();
 Console.WriteLine("Enter Service:");
 service = Console.ReadLine();
 student.Add(name);
 studentService.Add(service);
 Console.WriteLine("\nDo you want to buy a ticket \n[1] Yes \t [2] No");
 option = Convert.ToInt32(Console.ReadLine());
 // Generate a unique ticket number for each student and display it along with their 
name and service requested. 
 Random random = new Random();
 int randomNumber = random.Next(100, 1000);
 int ticketNumber = randomNumber;
 ticket.Add(ticketNumber);
 
 } while (option != 2);
 Console.WriteLine("\nTickets bought : " + student.Count);
 for (int i = 0; i < student.Count;i++)
 {
 Console.WriteLine("Number : " + i);
 Console.WriteLine("Name: " + student[i] + "\tService: " + studentService[i] + "\tTicket 
Number: " + ticket[i] + "\n");
 }
 Console.ReadKey();
 }
}

