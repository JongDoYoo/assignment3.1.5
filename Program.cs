using System.ComponentModel.Design;

namespace assignment3._1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {         
            int[] ints = { 0, 2, 1, 1, 9, 1, 1 };
            
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == ints[i+1])
                {
                    ints[i] = 0;
                    ints[i+1] = 0;
                    Console.WriteLine("[{0}]", string.Join(", ", ints));
                    break;
                }                                                              
            }
        }   
           
    }   

        
}
