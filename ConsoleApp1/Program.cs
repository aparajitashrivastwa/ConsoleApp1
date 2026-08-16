using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating object of student class
            Student student = new Student();
            student.AcceptDetails();
            student.CheckScholarshipEligibility();
            student.CheckCourseForScholarship();
            student.DisplayDetails();
            Console.ReadKey();
        }
        /// <summary>
        /// student class to represent a student in the admission process
        /// </summary>
        class Student
        {
            public int AdmissionNumber;
            public string Name;
            public double Grnumber;
            public string Course;
            public int Semester;

            //private data members
            private double Fees;
            private bool IsScholarshipEligible;
            private bool IsCourseEligibleForScholarship;

            //constant
            private const double ScholarshipRate = 0.20;

            //default constructor
            public Student()
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("      STUDENT ADMISSION SYSTEM      ");
                Console.WriteLine("-------------------------------------");

                //default values
                Course = "Computer Science";
                Semester = 5;
                Console.WriteLine("Student Object created successfully");
                Console.WriteLine("-------------------------------------");
            }
            //method to accept student details
            public void AcceptDetails()
            {
                Console.WriteLine("Enter Admission Number:");
                AdmissionNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Name    :");
                Name = Console.ReadLine();

                Console.WriteLine("Enter GR Number       :");
                Grnumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Course          :");
                Course = Console.ReadLine();

                Console.WriteLine("Enter Semester        :");
                Semester = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Fees            :");
                Fees = Convert.ToDouble(Console.ReadLine());
            }
            //method to check scholarship eligibility
            public void CheckScholarshipEligibility()
            {
                if (Fees > 50000)
                {
                    IsScholarshipEligible = true;
                    
                }
                else
                {
                    IsScholarshipEligible = false;
                }
            }
            public void CheckCourseEligibilityForScholarship()
            {
                if (Course == "computer science" || Course == "information technology")
                {
                    IsCourseEligibleForScholarship = true;
                }
                else
                {
                    IsCourseEligibleForScholarship = false;
                }
            }
            public void CheckCourseForScholarship()
            {
                if (IsScholarshipEligible && IsCourseEligibleForScholarship)
                {
                    Console.WriteLine("Student is eligible for scholarship.");
                }
                else
                {
                    Console.WriteLine("Student is not eligible for scholarship.");
                }
            }

            //method to display student details
            public void DisplayDetails()
            {
                double FinalFees = Fees;
                if(IsScholarshipEligible && IsCourseEligibleForScholarship)
                {
                    FinalFees = Fees - (Fees * ScholarshipRate);
                    Console.WriteLine("Scholarship Applied. Final Fees: " + FinalFees);
                }
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("              STUDENT DETAILS                ");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Admission Number    : " + AdmissionNumber);
                Console.WriteLine("Name                : " + Name);
                Console.WriteLine("Course              : " + Course);
                Console.WriteLine("Semester            : " + Semester);
                Console.WriteLine("Fees                : " + Fees);
                Console.WriteLine("Scholarship Eligible: " + (IsScholarshipEligible ? "Yes" : "No"));
                Console.WriteLine("Course Eligible     : " + (IsCourseEligibleForScholarship ? "Yes" : "No"));
                Console.WriteLine("Final Fees          : " + FinalFees);
                Console.WriteLine("-------------------------------------------------");
            }
        }
    }
}
