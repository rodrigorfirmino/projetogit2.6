using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetogit_2._6
{
    internal class Globais
    {
        public struct Utilizador
        {
            public string NomeUtilizador;
            public string NomeReal;
            public string email;
            public string PalavraPasse;
            public DateTime DataNascimento;
            public string CaminhoImagem;
            public string pathToFile;
        }

        public static Utilizador[] listaUtilizadores = new Utilizador[50];

        public static int posicaoVazia = 0;
    }

}

