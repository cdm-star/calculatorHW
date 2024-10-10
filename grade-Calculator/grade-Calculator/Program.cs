/*Colin Moore 
 * Class:IGME.201.01 - Interac Des & Alg Prob Sol III
Due Date: 10/13/2024
 */

namespace grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = "Colin";
            Console.WriteLine("Welcome " + studentName);
            Console.WriteLine("Here are your grades: ");
            int sum = 0;
            int average = 0;
            //initalize and declare
            int[] grades = { 100,92,87,200,-20,52,82,75,67,88  };

            //for loop to print out values in my array
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
                if ((grades[i] >= 90) && (grades[i] <= 100))
                {
                    Console.WriteLine("This grade is A!");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW a perfect score!");
                    }
                }
                else if ((grades[i] <= 89) && (grades[i]) >= 80)
                {
                    Console.WriteLine("This grade is a B");
                }
                else if ((grades[i] >= 70) && (grades[i] <= 79))
                {
                    Console.WriteLine("This grade is a C");
                }
                else if ((grades[i] >= 65) && (grades[i] <= 69))
                {
                    Console.WriteLine("This grade is a D");
                }
                else if ((grades[i] >= 0) && (grades[i] <= 64))
                {
                    Console.WriteLine("This grade is a F");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
               
               
            }

            for (int i = 0; i < grades.Length; i++) {

                sum += grades[i];
                
            }
            Console.WriteLine("The value of sum is "+ sum);
            
            average = sum / grades.Length;
            Console.WriteLine("Your final calculated average is: " + average);
            Console.WriteLine("We have displayed all grades for " + studentName);
        }
       
    }
}
