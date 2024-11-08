using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpFeatureApp;
using HR;
using Bank;
using Taxation;
using PenaltyHandler;
namespace CSharpFeatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object creation
            Account acct = new Account(15000);
            // Event Registation
            // registering events with delegate instance
            acct.underBalance += Penaltyhandler.ServiceDisconnectionPenaltyCharges;
            
            acct.underBalance += Penaltyhandler.NotificationPenaltyCharges;
            acct.overBalance += TaxHandler.PayIncomeTax;
            // object invocation
            acct.Withdraw(8000);

            acct.Deposit(250000);

            Console.ReadLine();
        }
    }
}

/*
 MathEngine engine = new MathEngine();
            engine.Add(76, 89);
            engine.Add(76, 89, 87);

            MathEngine.ViewNames("Sarika", "Manoj", "Charan", "Chetan");
            MathEngine.ViewNames("Raj", "Amita", "Shishir");
            MathEngine.ViewNames("Sameer", "Sagar");


            //  MathEngine.ShowDetails(56);
            // MathEngine.ShowDetails("Ravi Tambade");
            //  MathEngine.ShowDetails(76.8);
            Person person = new Person();
            MathEngine.ShowDetails(person);
            Complex complex = new Complex();//early binding
            Complex c1 = new Complex(22, 33); // early binding
            Complex c2 = new Complex(11, 11);

            Complex c3 = c1 + c2;  //
            Console.WriteLine(c3);  //ToString () method 
                                    //C3 type is complex
                                    //Complex class inherited
                                    // Parent of Complext is Object
                                    //Complex has implementation ToString
                                    //Object also has implementation of ToString

            Employee emp = new Employee { Id = 12, Name = "Raj", BasicSalary = 5000, DA = 500, HRA = 20000 };
            double packageEmp = emp.ComputePay();
            Console.WriteLine(packageEmp);

            emp = new Manager { Id = 13, Name = "Manish", BasicSalary = 5000, DA = 500, HRA = 20000, Incentive = 45000 };
            double packageMgr = emp.ComputePay();
            Console.WriteLine(packageMgr); 
*/


/*
 
 * // Compile time, early binding, static binding
*//*Handler.PayGST();
Handler.PayIncomeTax();
Handler.PayProfessionalTax();  
Handler.PayServiceTax();*//*

//register method with delegate instance
//address of function is passed 
Operation opn1 = new Operation(TaxHandler.PayIncomeTax);
Operation opn2 = new Operation(TaxHandler.PayServiceTax);
Operation opn3 = new Operation(TaxHandler.PayProfessionalTax);
//opn1.Invoke(34);                   // invoke = call the function which address is stored
//opn2.Invoke(34);
//opn3.Invoke(34);

// Store the address of all function in list way i.e chain
//broadcasting mechanism like
Operation masterOperation = null;
masterOperation += opn1;
masterOperation += opn2;
masterOperation += opn3;

masterOperation.Invoke(56);
Console.WriteLine("After detachment ");
masterOperation -= opn3;            //
masterOperation.Invoke(45);

 */