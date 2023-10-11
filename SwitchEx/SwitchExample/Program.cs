// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int totaljugador = 0;
int totalDealer = 0;
int num = 0;
int platziCoins = 0;
string message = "";
string otraCarta = "";
string switchcontrol = "menu";
System.Random random = new System.Random();
while (true) {

    Console.WriteLine("Bienvenidos a P L A T Z I N O");
    Console.WriteLine("Cuantos PlatziCoins deseas? \n " +
        "Ingresa un numero entero \n" +
        "Recuerda que necesitas uno por ronda \n"
        );
    platziCoins = int.Parse( Console.ReadLine() );

    for (int i = 0; i < platziCoins; i++)
    {

        totaljugador = 0;
        totalDealer = 0;
        switch (switchcontrol)
        {
            case "menu":

                Console.WriteLine("Escriba '21' para jugar a 21");
                switchcontrol = Console.ReadLine();
                i = i -1;
                break;

            case "21":

                do
                {
                    num = random.Next(1, 12);
                    totaljugador = totaljugador + num;
                    Console.WriteLine("Toma tu carta");
                    Console.WriteLine($"Tu carta es: {num} ");
                    Console.WriteLine("Deseas otra carta?");
                    otraCarta = Console.ReadLine();
                } while (otraCarta == "si" || otraCarta == "Si" || otraCarta == "yes");

                totalDealer = random.Next(12, 23);
                Console.WriteLine($"El dealer tiene: {totalDealer} !");
                if (totaljugador >= totalDealer && totaljugador < 22)
                {
                    message = "you won!";
                    switchcontrol = "menu";
                }
                else if (totaljugador >= 22)
                {
                    message = "you lost, you went too far";
                    switchcontrol = "menu";
                }
                else if (totalDealer >= 22)
                {
                    message = "you won, the dealer went too far";
                    switchcontrol = "menu";
                }
                else if (totaljugador <= totalDealer)
                {
                    message = "you lost";
                    switchcontrol = "menu";
                }
                else
                {
                    message = "condition not valid";
                }

                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("condicion no valida de entrada al C A S I N O");
                switchcontrol = "menu";
                break;

        }

    }
}