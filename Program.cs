using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter_Controlled_While_Loop_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numStud,student=1,numM=0,numF=0,numErrors=0;
            char Gender;
            Console.Write("Hom many students ? ");
            numStud = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter gender code of M,m or F,f for all " + numStud + " students");
            while (student <= numStud)
            {
                Console.Write("\nStudent\t"+student+"\t:");
                
                Gender = Convert.ToChar(Console.ReadLine());
                if (Gender == 'M' || Gender == 'm')
                {
                    numM++;
                }
                else if (Gender == 'F' || Gender == 'f')
                {
                    numF++;
                }
                else
                {
                    numErrors++;
                }
                student++;
            }
            Console.WriteLine("\nNumber of male: " + numM);
            Console.WriteLine("Number of female: " + numF);
            Console.WriteLine("Number of errors: " + numErrors);
            Console.ReadLine();
        }
    }
}
