using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public class RegistroUsuario
    {
        public int Id { get; private set; }
        public Usuario Usuario { get; private set; }
        public int UsuarioID { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime DataSaida { get; private set; }
        public string IpDaMaquina { get; private set; }
    }
}
