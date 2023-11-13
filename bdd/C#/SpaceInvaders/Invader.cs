using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceInvaders
{
    public class Invader
    {
        private const char inv = '#';
        public string Motif = inv.ToString();

        public Invader(string motif)
        {
            Motif = motif;
        }

        public override string ToString()
        {
            return Motif.ToString();
        }
    }



}
