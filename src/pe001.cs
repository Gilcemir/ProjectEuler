using System;
namespace Project{
    public class p001{
        public static void Get(){
            Console.WriteLine("1 - Multiples of 3 or 5");


            int num = 1000;
            int sum = 0;
            for(int i = 1; i< num; i++){
                if(i%3==0 || i%5==0)
                    sum+=i;
            }
            Console.WriteLine(sum);        
        }
    }
}