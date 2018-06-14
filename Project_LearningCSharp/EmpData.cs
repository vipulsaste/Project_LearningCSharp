using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_LearningCSharp
{
    class EmpData
    {
        Dictionary<int, int> hash = new Dictionary<int, int>();

        public void empNum(int size)
        {
            int[] a = new int[size];
            foreach (int s in a)
            {
                Console.WriteLine("Enter Employee Number");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Salary");
                int sal = int.Parse(Console.ReadLine());
                hash.Add(num, sal);
            }


            Console.WriteLine("HIGHEST SALARY EMPLOYEE DATA");
            int max = hash.Values.Max();
            int key = hash.FirstOrDefault(x => x.Value == hash.Values.Max()).Key;
            Console.WriteLine("The EMP Number is : "+ key + "     " +  "The maximum salary is: " + max);
            Console.Read();

            //foreach(KeyValuePair<int, int> pair in hash)
            //{
            //    //  Console.WriteLine("Emp NUm: " + pair.Key);
            //    //  Console.WriteLine("Emp Sal: " + pair.Value);   
            //}
          //  Console.Read();

        }
        
        





    }
}
