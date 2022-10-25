using System;

class Program {
  static int remain(int n){
    return(n-n%10) / 10;
  }
  static int an_num(int n){
    int cur = n% 10;
    int counter = 0;
    while (n > 0){
      cur = n % 10;
      if (cur <8 && cur % 3 != 0 && cur % 4 !=0){
        counter++;
      }
      n = remain(n);
    }
    return counter;
  }
  static int sum_pair(int n){
    int prev = n% 10;
    int cur = ((n-n%10) / 10)%10;
    int sum = 0;
    while (n > 0){
      prev = n% 10;
      n = remain(n);
      cur = n%10;
      n = remain(n);  
      if ( (cur+prev) % 2 == 0){
        sum += (cur+prev);
      }
    }
    return sum;
  }
  static bool lucky_num (int n){

    int num_am = 0;
    int n1=  n;
    while (n < 0){
      num_am++;
      n = remain(n);
    }
    int sum_frst = 0, sum_sec =0 ; 
    for (int i = 0; i < num_am / 2; i++){
      sum_frst += n1 % 10;
      n1 = remain(n1);
    }
    for (int i = 0; i < num_am / 2; i++){
      sum_sec += n1 % 10;
      n1 = remain(n1);
    }
    return sum_sec==sum_frst;
  }
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int res = an_num(n);
    int res1 = sum_pair(n1);
    string res2 = (lucky_num(n2))?"везучее":"невезучее";
    Console.WriteLine($"Количество цифр числа, меньше 8 и не кратных ни 3 ни 4 равно: {res}");
    Console.WriteLine($"Сумма четных пар чисел: {res1}");
    Console.WriteLine($"Число {n2} {res2}");
  }
  //4571862
}
