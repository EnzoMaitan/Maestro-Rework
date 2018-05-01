using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.DAO;
using Maestro_Rework.Classes.Entidades;

namespace Maestro_Rework.Classes
{
    public static class EnviadorDeEmail
    {
        public static void Enviar_Rec_Senha(string emailAlvo)
        {
            var usuarioDAO = new UsuarioDAO();

            var usuario = usuarioDAO.Usuario().FirstOrDefault(x=>x.Email == emailAlvo)
                ?? throw new ArgumentNullException("", "Email Invalido");

            usuario.CodigoSenha = GeradorDeCodigo.GerarCodigoRecuperacaoSenha();

            usuarioDAO.Atualizar(usuario);

            SmtpClient client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                Timeout = 10000,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new System.Net.NetworkCredential("contatoauros@gmail.com", "batatauniversal")
            };
            MailMessage objeto_mail = new MailMessage
            {
                From = new MailAddress("from@server.com")
            };
            objeto_mail.To.Add(new MailAddress(emailAlvo));
            CriarCorpoDoEmail(usuario, objeto_mail);
            client.Send(objeto_mail);
        }

        private static void CriarCorpoDoEmail(Usuario usuario, MailMessage objeto_mail)
        {
            objeto_mail.Subject = "Recuperar a senha";
            objeto_mail.Body = "Seu código se recuperação é:" + usuario.CodigoSenha;
        }
    }
}
