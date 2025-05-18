using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieOrtografica
{
    public class TrieNo
    {
        public Dictionary<char, TrieNo> Filhos { get; set; }
        public bool IsFinalPalavra { get; set; }

        public TrieNo()
        {
            Filhos = new Dictionary<char, TrieNo>();
            IsFinalPalavra = false;
        }
    }
}
