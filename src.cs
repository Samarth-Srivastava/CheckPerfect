using System;
using System.IO;

class MAIN  {
    public static void Main(string[] args) {
        string number_str = Console.ReadLine();
        int N = Convert.ToInt32(number_str);
        
        for(int i = 0; i < N; i++){
            string a_str = Console.ReadLine();
            int A =  Convert.ToInt32(a_str);

            int sumOffactors = 1;
            for(int j = 2; j*j <= A; j++){
                if(A%j == 0){
                    sumOffactors = sumOffactors + j + (int)A/j;
                }
            }
            
            if(sumOffactors == A){
                Console.WriteLine("YES");
            }
            else{
                Console.WriteLine("NO");
            }
        }
    }
}
