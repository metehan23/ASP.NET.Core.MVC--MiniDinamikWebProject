using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProje.Models
{
    public static class Repository
    {
        private static List<Anket> _anket = new List<Anket>();

        public static List<Anket> Ankett
        {
            get
            {
                return _anket;
            }
        }
        public static void AddAnket(Anket anket)
        {
            _anket.Add(anket);
        }
    }
}
