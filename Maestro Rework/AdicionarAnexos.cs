using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework
{
    public class AdicionarAnexos
    {
        public static string caminho;
        public byte[] databaseFilePut(string _caminho)
        {
            caminho = _caminho;
            byte[] file;
            using (var stream = new FileStream(caminho, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            return file;
        }
    }
}
