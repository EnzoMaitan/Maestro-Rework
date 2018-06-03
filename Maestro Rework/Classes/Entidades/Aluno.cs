using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class Aluno : Usuario
    {
        public Aluno()
        {
                
        }

        public Aluno(string login, string nome, string senha, string email)
        : base(login, nome, senha, email)
        {
            Nivel = 1;
            Cargo = "Aluno";
        }
    }
}
