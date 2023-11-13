using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Space
    {
        public int NbLignes { get; set; }
        public int NbColonnes { get; set; }
        public List<List<char>> Grille { get; set; }
        public char[,] tableau;

        public Space(int nbLignes, int nbColonnes)
        {
            NbLignes = nbLignes;
            NbColonnes = nbColonnes;
            Grille = new List<List<char>>();
            tableau = new char[NbLignes, NbColonnes];

            for (int i = 0; i < NbLignes; i++)
            {
                Grille.Add(new List<char>());
                for (int j = 0; j < NbColonnes; j++)
                {
                    Grille[i].Add(' ');
                    tableau[i, j] = ' ';
                }
            }

            for (int i = 0; i < NbColonnes; i++)
            {
                tableau[0, i] = '#';
            }

            for (int i = 0; i < NbLignes; i++)
            {
                for (int j = 0; j < NbColonnes; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        Console.Write("┌------");
                    }
                    else if (i == 0 && j == NbColonnes - 1)
                    {
                        Console.Write("-------┐");
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
                        Console.Write("─------------");
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
                if (position >= 0 && position < Grille[i].Count && Grille[i][position] == '#')
                {
                    Grille[i][position] = ' ';
                    break;
                }
                System.Threading.Thread.Sleep(50);
            }
        }
    }
}