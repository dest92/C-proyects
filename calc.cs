using System.Web;

//LINK TO PROJECT github.com/dest92/consoleCalculator
class Calculadora
{
    double numerosElegidos;
    double resultado;
    bool addedQuestion = false;



    //This variable is for the numbers that i add to make operations
    double tempNumber;


    static void Main()
    {
        Calculadora calc = new Calculadora();

        //Change the color of the console letters
        Console.ForegroundColor = ConsoleColor.Green;


       // calc.CalcReal();

        calc.Menu();

    }

    public void CalcReal() {

        Calculadora calc = new Calculadora();

        //Pedir la operación
        Console.WriteLine("Introduzca la operación a calcular");
        
        //Variable que guarda la operación
        string operacion = Console.ReadLine();

        //Convertir la operación a un array
        char[] ch = operacion.ToArray();


        //Bucle que recorra la operación
        for(int i = 0; i < ch.Length; i++)
        {

            if(ch[i] == '*')
            {
                Console.WriteLine("La Suma es: ");
                Console.WriteLine(int.Parse(ch[i-1].ToString()) * int.Parse(ch[i+1].ToString()));
            }
        }

        }

    public void Menu()
    {
        // This variable controls the Menu
        int op = 1;

        


        Calculadora calc = new Calculadora();
        Console.WriteLine("Bienvenido a la calculadora!");
        Console.WriteLine("Introduzca el número");
        calc.numerosElegidos = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("El número introducido fue {0}", calc.numerosElegidos);


        while (op != 0)
        {
            //Si el numero elegido es 0, pido que introduzca un numero
            if (calc.numerosElegidos == 0)
            {
                Console.WriteLine("Introduzca un número");
                calc.numerosElegidos = double.Parse(Console.ReadLine());
            }


            Console.WriteLine("Que desea hacer? 0- Salir | 1- Sumar | 2-Multiplicar | 3-Dividir | 4-Restar | 5-Resultado | 6-Secret");
            //Controls the Menu
            op = int.Parse(Console.ReadLine());


            switch (op)
            {


                case 1:

                    calc.Sum();
                    break;


                case 2:

                    calc.Multiplication();

                    break;

                case 3:
                    calc.Division();
                    break;


                case 4:
                    calc.Resta();
                    break;


                //case 5:
                //    Console.WriteLine(calc.resultado);
                //    calc.resultado = 0;
                //    calc.numerosElegidos = 0;
                //    calc.addedQuestion = false;
                //    break;

                case 5:
                    calc.Solve();
                    break;
            }
        }

    }

    public void Sum()
    {
 
        //Calculadora calc = new Calculadora();
        Console.WriteLine("Introduzca el número: ");
        tempNumber = double.Parse(Console.ReadLine());

        if (addedQuestion == false)
        {
            resultado += tempNumber + numerosElegidos;
        }

        if (addedQuestion == true)
        {
            resultado += tempNumber;
        }

        addedQuestion = true;

    }



    public void Resta()
    {
        Console.WriteLine("Introduzca un número: ");
        tempNumber = double.Parse(Console.ReadLine());

        if (addedQuestion == false)
        {
            resultado -= tempNumber - numerosElegidos;
        }

        if (addedQuestion == true)
        {
            resultado -= tempNumber;
        }

        addedQuestion = true;

    }

    public void Multiplication()
    {
        Console.WriteLine("Introduzca un número");
        tempNumber = double.Parse(Console.ReadLine());

        if (addedQuestion == false)
        {
            resultado += (tempNumber * numerosElegidos);
        }


        if (addedQuestion == true)
        {

            resultado *= tempNumber;
        }

        addedQuestion = true;
    }
    
    public void Division()
    {
        Console.WriteLine("Introduzca un número");



        tempNumber = double.Parse(Console.ReadLine());

        if (addedQuestion == false)
        {
            resultado += (numerosElegidos / tempNumber);
        }


        if (addedQuestion == true)
        {

            resultado /= tempNumber;
        }

        addedQuestion = true;
        //calc.numerosElegidos = 0;

    }





    public void Solve()
    {

        Console.WriteLine(String.Concat("\n",$"El resultado es: {resultado}","\n"));
        resultado = 0;
        numerosElegidos = 0;
        addedQuestion = false;

    }


    

}
