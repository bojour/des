using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanceDes
{
    class Program
    {
        static void Main(string[] args)
        {
            int iDes, iCompteur;
            int iNbDes = 0;
            int iNbFaces = 0;
            bool bCheck = true;
            Random rnd = new Random();

            do
            {
                Console.Clear();
                try
                {
                    while (iNbFaces < 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Combien de dés voulez-vous lancer?");
                        iNbDes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Combien de faces ont vos dès?");
                        iNbFaces = Convert.ToInt32(Console.ReadLine());
                        if (iNbFaces < 2)
                        {
                            Console.WriteLine("!Erreur! Veuilliez retaper.");
                        }
                        Console.ReadKey();
                    }

                    for (iCompteur = 0; iCompteur < iNbDes; iCompteur++)
                    {
                    iDes = rnd.Next(1, iNbFaces + 1);
                    Console.WriteLine("Resultat {1}: {0}", iDes, iCompteur + 1);
                    }
                    Console.ReadKey();
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Erreur de syntaxe, merci de recommencer");
                    bCheck = false;
                    Console.ReadKey();
                }

            } while (!bCheck);

        }
    }
}
