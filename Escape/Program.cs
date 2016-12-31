using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Escape.Properties;
using System.Media;

namespace Escape
{
    class Program
    {
        static void play(int time, int time2, int time3, int Etime)
        {
            SoundPlayer beep = new SoundPlayer(Resources.beep);
            Console.WriteLine("START \n");
            time = time * 60000;
            time2 = time2 * 60000;
            time3 = time3 * 60000;
            Etime = Etime * 60000;
            
            while (time > 0)
            {
                Console.WriteLine(Convert.ToString(time / 60000) + " minutes/" + Convert.ToString(time / 1000) + " seconds");
                System.Threading.Thread.Sleep(10000);
                time = time - 10000;
            }
            Console.WriteLine("GET BACK!!!!");
            beep.Play();
            while (time2 > 0)
            {
                Console.WriteLine(Convert.ToString(time2 / 60000) + " minutes/" + Convert.ToString(time2 /1000) + " seconds");
                System.Threading.Thread.Sleep(10000);
                time2 = time2 - 10000;
            }
            Console.WriteLine("Go... again");
            beep.Play();
            while (time3 > 0)
            {
                Console.WriteLine(Convert.ToString(time3 / 60000) + " minutes/" + Convert.ToString(time3 / 1000) + " seconds");
                System.Threading.Thread.Sleep(10000);
                time3 = time3 - 10000;
            }
            Console.WriteLine("Escape!!!!!!");
            beep.Play();
            while(Etime > 0)
            {
                Console.WriteLine(Convert.ToString(Etime / 60000) + " minutes/" + Convert.ToString(Etime / 1000) + " seconds");
                System.Threading.Thread.Sleep(10000);
                Etime = Etime - 10000;
            }
            Console.Write("Game Finished, click any key to conntinue: ");
            beep.Play();
            Console.ReadKey();
        }

        static void prgm()
        {
            try
            {
                Console.Write("First play time: ");
                int play1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Time to get back: ");
                int back = Convert.ToInt32(Console.ReadLine());
                Console.Write("Second play time: ");
                int play2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Time to escape: ");
                int Etime = Convert.ToInt32(Console.ReadLine());
                Console.Write("Total game time = " + Convert.ToString(play1 + back + play2 + Etime) + " minutes, press any key to start: ");
                Console.ReadKey();
                Console.Clear();
                play(play1, back, play2, Etime);
            }
            catch
            {
                Console.WriteLine("please type a valid intager, press any key to continue: ");
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            bool done = false;
            Console.WriteLine("type setup to begin setup or exit to quit: ");
            while (done == false)
            {
                string input = Console.ReadLine();
                if (String.Compare(input, "setup") == 0)
                {
                    Console.Clear();
                    prgm();
                    Console.Clear();
                    Console.WriteLine("type setup to begin setup or exit to quit: ");
                }
                else if (String.Compare(input, "exit") == 0)
                {
                    done = true;
                }
                else
                {
                    Console.WriteLine("please type setup or exit: ");
                }
            }
        }
    }
}
