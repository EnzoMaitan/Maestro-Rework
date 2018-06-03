using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class Administrador : Usuario
    {
        public Administrador()
        {
                
        }

        public Administrador(string login, string nome, string senha, string email)
        : base(login, nome, senha, email)
        {
            Nivel = 3;
            Cargo = "Administrador";
        }
    }
}
