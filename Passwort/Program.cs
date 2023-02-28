
//Passwort setze

int k = 1, p = 2;
do { 
try
{
   
    Console.WriteLine($"Geben sie ein Benutzername mit min 5 stellen ein: ");
    Console.Write($"Setzen sie Ihr Benutzername: ");
    string bn = Console.ReadLine();
    Console.WriteLine($"Geben sie ein Passwort mit min 12 stellen ein: ");
    Console.Write($"Setzen sie Ihr Passwort: ");
    string pw = Console.ReadLine();
    if (bn.Length >= 5 || bn.Length== 5 && pw.Length >= 12 || pw.Length == 12)
    {
        while (true)
        {








            //Eingabe bereich

            Console.Write($"Geben sie Ihr Benutzername ein: ");
            string eingb = Console.ReadLine();
            Console.Write($"\nGeben sie Ihr Passwort ein: ");
            string eingpw = Console.ReadLine();
            Console.Clear();
            if (eingb == bn && eingpw == pw)
            {
                Console.Write($"Erfolgreich eingeloggt");
                break;

            }
            else
            {
                Console.WriteLine($"\n{k}te Falsche eingabe versuchen sie es erneut. {p} versuche übrig\n ");

                k++;
                p--;

                if (k == 4)
                {
                    Console.WriteLine($"Zu viele falsche eingaben melden sie sich beim Support");
                    break;
                }
            }





        }

    }

    else
    {
        Console.WriteLine($"Falsche eingabe");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
    }
while (true) ;




