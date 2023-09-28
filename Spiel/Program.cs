using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Spiel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Der Super-Raub";
            
            // Abschnitt für das Titelbild
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("******************************************************************");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("******************************************************************");

            Console.WriteLine();
            Console.WriteLine("                      Der Super-Raub!                             ");
            Console.WriteLine();
            Console.WriteLine("     Versuche den Jahrhundertraub und stehle die Mona Lisa!       ");
            Console.WriteLine();

            Console.WriteLine("******************************************************************");
            Console.WriteLine("******************************************************************");
            Console.WriteLine("******************************************************************");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Drücke die a-Taste und bestätige mit der Enter-Taste umd das Spiel zu starten!");
            string starteingabe = Console.ReadLine();
            if (starteingabe == "a")
            {
                // a wurde eingegeben, das Spiel startet
                System.Console.Clear();
            }
            else
            {
                // falsche Eingabe, das Spiel wird beendet
                Console.WriteLine("du hast nicht a eingegeben, sondern " + starteingabe + ". Das Spiel wird beendet!");
            }

            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("Los!");
            Thread.Sleep(1000);

            //Szene 1
            // Einführungstext 1
            Console.WriteLine("Als Meisterdieb bist du auf der Suche nach dem nächsten grossen Raub. Du stehst deshalb in Paris vor der Louvré – dein Ziel: Die Mona Lisa stehlen! Bist du mutig genug und gehst ins Museum rein?");
            // Option A
            Console.WriteLine("a: Ja!");
            //Option B
            Console.WriteLine("b: Nein!");
            Console.WriteLine("Achtung! Du hast nur 20 Sekunden Zeit zum Antworten - sonst hast du verloren!");
            string eingabe = Reader.ReadLine(20 * 1000);
            //If und Else
            if (eingabe.ToLower() == "a")

            {
                // Szene 2
                // Einfürhungstext 2
                Console.WriteLine("Du hast dich entschieden, den Raub durchzuführen – bravo! Betrittst du das Museum durch den Haupteingang?");
                // Option A
                Console.WriteLine("a: Ja!");
                //Option B
                Console.WriteLine("b: Nein!");
                Console.WriteLine("Schreibe a oder b! Bestätige mit der Enter-Taste.");
                string eingabe2 = Console.ReadLine();
                if (eingabe2.ToLower() == "b")

                {
                    // Szene 3
                    // Einführungstext 3
                    Console.WriteLine("Clevere Entscheidung. Du verschaffst dir Zutritt über einen geheimen Tunnel. Du bist nun im Museum. Wartest du mit dem Raub, bis alle Besucher gegangen sind?");
                    // Option A
                    Console.WriteLine("a: Ja!");
                    // Option B
                    Console.WriteLine("b: Nein!");
                    Console.WriteLine("Schreibe a oder b! Bestätige mit der Enter-Taste.");
                    string eingabe3 = Console.ReadLine();
                    if (eingabe3.ToLower() == "a")

                    {
                        // Szene 4
                        //Einführungstext 4
                        Console.WriteLine("Du bist nun ganz alleine im Museum. Vor dem Raum, wo die Mona Lisa hängt, schläft auf einem Stuhl ein Security. Schleichst du an ihm durch?");
                        // Option A
                        Console.WriteLine("a: Ja!");
                        // Option B
                        Console.WriteLine("b: Nein!");
                        Console.WriteLine("Schreibe a oder b! Bestätige mit der Enter-Taste.");
                        string eingabe4 = Console.ReadLine();
                        if (eingabe4.ToLower() == "b")

                        {
                            // Szene 5
                            // Einführungstext 5
                            Console.WriteLine("Weise gewählt, du nimmst den zweiten, unbewachten Eingang in den Raum, wo die Mona Lisa hängt. Sie wird von einem Lasersystem geschützt. Versuchst du das Lasersystem über das Kontrollkästchen zu deaktivieren?");
                            // Option A
                            Console.WriteLine("a: Ja!");
                            // Option B
                            Console.WriteLine("b: Nein!");
                            Console.WriteLine("Schreibe a oder b! Bestätige mit der Enter-Taste.");
                            string eingabe5 = Console.ReadLine();
                            if (eingabe5.ToLower() == "b")

                            {
                                // Szene 6
                                // Einführungstext 6
                                Console.WriteLine("Richtige Entscheidung. Du konntest dich über die Decke abseielen und das Bild von oben greifen.");
                                Console.WriteLine("Gratulation! Jetzt bist du Milliardär!");
                            }
                            else if (eingabe5.ToLower() == "a")
                            {
                                Console.WriteLine("GAME OVER! Du hast den Alarm ausgelöst");
                            }
                            else if (eingabe == "Langsam")
                            {
                                Console.WriteLine("Die Zeit ist abgelaufen! Du hast verloren!"); 
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet!");
                            }
                        }
                        else if (eingabe4.ToLower() == "a")
                        {
                            Console.WriteLine("GAME OVER! Der Security ist aufgewacht und verhaftet dich!");
                        }
                        else if (eingabe == "Langsam")
                        {
                            Console.WriteLine("Die Zeit ist abgelaufen! Du hast verloren!");
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet!");
                        }
                    }
                    else if (eingabe3.ToLower() == "b")
                    {
                        Console.WriteLine("GAME OVER! Du fällst den Besuchern auf, weil du verdächtig herumschleichst – sie melden dich der Security und du wirst ferstgenommen.");
                    }
                    else if (eingabe == "Langsam")
                    {
                        Console.WriteLine("Die Zeit ist abgelaufen! Du hast verloren!");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet!");
                    }
                }
                else if (eingabe2.ToLower() == "a")
                {
                    Console.WriteLine("GAME OVER! Die Security hat ein Fahndungsfoto von dir und nimmt dich fest!");
                }
                else if (eingabe == "Langsam")
                {
                    Console.WriteLine("Die Zeit ist abgelaufen! Du hast verloren!");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet!");
                }
            }
            else if (eingabe.ToLower() == "b")
            {
                Console.WriteLine("GAME OVER! Die Mona Lisa bleibt in der Louvré, es winkt keine fette Belohnung für dich!");
            }
            else if (eingabe == "Langsam")
            {
                Console.WriteLine("Die Zeit ist abgelaufen! Du hast verloren!");
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe! Das Spiel wird beendet!");
            }
            Console.ReadKey();
        }
    }
    // Zusätzliche Klasse mit einer erweiterten Console.Readline-Funktion mit einer Timeout-Funktion
    class Reader
    {
        private static Thread inputThread;
        private static AutoResetEvent getInput, gotInput;
        private static string input;

        static Reader()
        {
            getInput = new AutoResetEvent(false);
            gotInput = new AutoResetEvent(false);
            inputThread = new Thread(reader);
            inputThread.IsBackground = true;
            inputThread.Start();
        }
        private static void reader()
        {
            while (true)
            {
                getInput.WaitOne();
                input = Console.ReadLine();
                gotInput.Set();
            }
        }
        // Die neue ReadLine-Methode
        public static string ReadLine(int timeOutMillisecs = Timeout.Infinite)
        {
            getInput.Set();
            bool success = gotInput.WaitOne(timeOutMillisecs);
            if (success)
            {
                return input;
            }
            else
            {
                return "Langsam";
                // throw new TimeoutException("User did not provide input within the timelimit");
            }
        }
    }
}
