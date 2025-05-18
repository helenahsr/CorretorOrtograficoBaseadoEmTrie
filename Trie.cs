using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieOrtografica
{
    class Trie
    {
        private TrieNo raiz;

        public Trie()
        {
            raiz = new TrieNo();
        }

        public void Inserir(string palavra)
        {
            TrieNo noAtual = raiz;
            foreach (char letra in palavra)
            {
                if (!noAtual.Filhos.ContainsKey(letra))
                {
                    noAtual.Filhos[letra] = new TrieNo();
                }
                noAtual = noAtual.Filhos[letra];
            }
            noAtual.IsFinalPalavra = true;
        }

        public bool Buscar(string palavra)
        {
            TrieNo noAtual = raiz;
            foreach (char letra in palavra)
            {
                if (!noAtual.Filhos.ContainsKey(letra))
                {
                    return false;
                }
                noAtual = noAtual.Filhos[letra];
            }
            return noAtual != null && noAtual.IsFinalPalavra;
        }

        public List<string> ComecaCom(string prefixo)
        {
            List<string> palavras = new List<string>();
            TrieNo noAtual = raiz;
            foreach (char letra in prefixo)
            {
                if (!noAtual.Filhos.ContainsKey(letra))
                {
                    return palavras;
                }
                noAtual = noAtual.Filhos[letra];
            }
            BuscarPalavras(noAtual, prefixo, palavras);
            return palavras;
        }

        private void BuscarPalavras(TrieNo noAtual, string prefixo, List<string> palavras)
        {
            if (noAtual.IsFinalPalavra)
            {
                palavras.Add(prefixo);
            }
            foreach (var filho in noAtual.Filhos)
            {
                BuscarPalavras(filho.Value, prefixo + filho.Key, palavras);
            }
        }

        public List<string> ListarPalavras()
        {
            List<string> palavras = new List<string>();
            ColetarTodasPalavras(raiz, "", palavras);
            return palavras;
        }

        private void ColetarTodasPalavras(TrieNo noAtual, string prefixo, List<string> palavras)
        {
            if (noAtual.IsFinalPalavra)
            {
                palavras.Add(prefixo);
            }
            foreach (var filho in noAtual.Filhos)
            {
                ColetarTodasPalavras(filho.Value, prefixo + filho.Key, palavras);
            }
        }
    }
}
