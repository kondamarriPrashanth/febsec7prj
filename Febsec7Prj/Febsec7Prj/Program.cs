// See https://aka.ms/new-console-template for more information
using Febsec7Prj;
using System.Reflection.Emit;
using System.Xml.Linq;
using System;
using System.Text;

Console.WriteLine("BANK LOGIN PAGE");
Console.WriteLine("Enter the UserName:");
string UserName=Console.ReadLine();
Console.WriteLine("Enter the UserId:");
int ACCNO=int.Parse(Console.ReadLine());
Bank b= new Bank();
Console.WriteLine(b.Authenticate("Ram", "ram123"));

