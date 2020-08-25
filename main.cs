using System;

class MainClass {
  public static int Main () {
    double h ; 
    char sexo ;
    /*
    double temp;
    Console.Write("Temp. em F >>> ");
    temp = double.Parse(Console.ReadLine());
    Console.WriteLine("Temp. em C >>> {0:0.0000}",Fahrenheit(temp));
    
*/
    Console.Write("Digite a altura >>> ");
    h = double.Parse(Console.ReadLine());
    Console.Write("Digite o sexo >>> ");
    sexo = char.Parse(Console.ReadLine());
    Console.WriteLine(CalcPeso(h,sexo)); // CHAMAR A FUNÇÃO QUE CALCULA O PESO

    return 0; //TEM QUE RETORNAR UM VALOR INTEIRO, POIS A MAIN NÃO É VOID.. É INT
  }

   public static double Fahrenheit (double f) {
   // Console.WriteLine ("Digite o Grau em C");
    return 5 * ((f-32)/9);

    //OU POSSO DESTA FORMA, PORÉM DESTA FORMA TENHO VARIAVEIS DESNECESSÁRIAS

    /* int c;
      c = 5 * ((f-32)/9);
      return c;
    */
  }

  public static double CalcPeso(double h,char sexo){
    double peso = 1;
    if(sexo == 'H'){
      return (72.7 * h) - 58;

    }else if( sexo == 'M'){
      return (62.1 * h) - 44.7;
    }
   return peso;
  }
}