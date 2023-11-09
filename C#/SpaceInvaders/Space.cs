using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Space
    {
        public int NbLignes = 10;
        public int NbColonnes = 10;
        public List<int> Grille;
        public int[,] tableau;

        public Space(int nbLignes, int nbColonnes, List<int> grille)
        {
            NbLignes = nbLignes;
            NbColonnes = nbColonnes;
            Grille = grille;

            tableau = new int[NbLignes, NbColonnes];
            for (int i = 0; i < NbLignes; i++)
            {
                for (int j = 0; j < NbColonnes; j++)
                {
                    tableau[i, j] = Grille[i * NbColonnes + j];
                    Console.WriteLine(tableau[i, j]);
                }

            }


            for (int i = 0; i < NbColonnes; i++)
            {
                tableau[0, i] = typeof(Invader).Name.GetHashCode();
            }

            for (int i = 0; i < NbLignes; i++)
            {
                for (int j = 0; j < NbColonnes; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("┌");
                    }
                    else if (i == 0 && j == NbColonnes - 1)
                    {
                        Console.Write("┐");
                    }
                    else if (i == NbLignes - 1 && j == 0)
                    {
                        Console.Write("└");
                    }
                    else if (i == NbLignes - 1 && j == NbColonnes - 1)
                    {
                        Console.Write("┘");
                    }
                    else if (i == 0 || i == NbLignes - 1)
                    {
                        Console.Write("─");
                    }
                    else if (j == 0 || j == NbColonnes - 1)
                    {
                        Console.Write("│");
                    }
                    else
                    {
                        Console.Write(tableau[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < NbLignes; i++)
            {
                for (int j = 0; j < NbColonnes; j++)
                {
                    sb.Append(tableau[i, j] + " ");
                }
                sb.AppendLine();
            }
            return sb.ToString().TrimEnd();
        }
        public void Tirer(int position)
        {
            for (int i = NbLignes - 1; i >= 0; i--)
            {
                tableau[i, position] = 0;
                Console.SetCursorPosition(position, i);
                Console.Write(" ");
                System.Threading.Thread.Sleep(50);
                if (i > 0 && tableau[i - 1, position] == typeof(Invader).Name.GetHashCode())
                {
                    tableau[i - 1, position] = 0;
                    Console.SetCursorPosition(position, i - 1);
                    Console.Write(" ");
                    break;
                }
            }
        }
    }

}

