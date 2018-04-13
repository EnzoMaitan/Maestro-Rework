using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;


namespace Maestro_Rework
{
    public class ConversorDeAnexos
    {
        public static string caminho;
        public byte[] DatabaseFilePut(string _caminho)
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
        public static byte[] ConverterImagem(System.Windows.Forms.OpenFileDialog ofd)
        {
            if (string.IsNullOrWhiteSpace(ofd.FileName))
                return null;
            using (var stream = new MemoryStream())
            {
                var imagem = Image.FromFile(ofd.FileName);
                imagem.Save(stream, ImageFormat.Png);
                stream.Position = 0;
                return stream.ToArray();
            }
        }
    }
}
