using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICAL_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            List<expense> expenses = new List<expense>();
            do
            {
                Console.WriteLine("===============");
                Console.WriteLine("Expense tracker module");
                Console.WriteLine("1.Add Expense");
                Console.WriteLine("2.View All Expense");
                Console.WriteLine("3. View Total Expense Amount");
                Console.WriteLine("4.Exit");

                try
                {
                    Console.WriteLine("Enter your choice=");
                    ch = Convert.ToInt32(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            {
                                try
                                {
                                    expense exp = new expense();
                                    exp.accdet();
                                    expenses.Add(exp);

                                    Console.WriteLine("Expense aded sucessfully");
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Error: Please enter a valid numeric value");

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error:" + ex.Message);

                                }
                                finally
                                {
                                    Console.WriteLine("Expenses Processing Completed");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (expenses.Count == 0)
                                    Console.WriteLine("No Expense");
                                else
                                {
                                    foreach (expense expense in expenses)
                                    {
                                        expense.dispDet();
                                    }
                                }

                                break;
                            }
                        case 3:
                            {
                                double t = 0;
                                foreach (expense expense in expenses)
                                {
                                    t = t + expense.amt;

                                }
                                Console.WriteLine("Total Expense=" + t);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Thank you for using Expense Tracker");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("INVALID Choice");
                                break;
                            }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: plese enter a vcalid menu choice");
                    ch = 0;
                }
            } while (ch != 4);

        }
        class expense
        {
            public int expId;
            public string category;
            public double amt;
            public string paymentMode;
            public DateTime expDate;

            //method 1: to accept expense details
            public void accdet()
            {
                Console.WriteLine("Enter expense id=");
                expId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter expense category=");
                category = Console.ReadLine();
                Console.WriteLine("Enter expense amount=");
                amt = Convert.ToDouble(Console.ReadLine());

                //throw exception for invalid amount

                if (amt <= 0)
                {
                    throw new Exception("Expense amount must be mor ethan ZERO");
                }
                Console.WriteLine("Enter payment Mode(Cash/UPI/Card)= ");
                paymentMode = Console.ReadLine();
                expDate = DateTime.Now;//to fetch and display the system date


            }
            //Method-2 to display expense details

            public void dispDet()
            {
                Console.WriteLine("^^^^^^^^^^^^^^^");
                Console.WriteLine("Expense Id=" + expId);
                Console.WriteLine("Category=" + category);
                Console.WriteLine("Amount=" + amt);
                Console.WriteLine("Payment Mode=" + paymentMode);
                Console.WriteLine("Date=" + expDate);
                Console.WriteLine("^^^^^^^^^^^^^^^^^");
            }

        }
    }
}
