using Maestro_Rework.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maestro_Rework.Classes.Entidades
{
    public  class QuestionarioUsuario
    {
        public int Id { get; private set; }

        public Usuario Usuario { get; private set; }
        public int UsuarioID { get; private set; }
        public Questionario Questionario { get; private set; }
        public int QuestionarioID { get; private set; }

        public bool Acesso { get; private set; }
        public bool Refez { get; private set; }

        public IList<AlternativaCorreta> AlternativaCorretas { get; private set; }

        public QuestionarioUsuario() { }

        public QuestionarioUsuario(Usuario usuario,string codigoDoQuestionario)
        {
            this.UsuarioID = usuario.Id;
            var questionarioDAO = new QuestionarioDAO();
            var questionario = questionarioDAO.Questionario().FirstOrDefault(x => x.CodigoAcesso == codigoDoQuestionario.ToUpper());
            if (questionario != null)
            {
                this.QuestionarioID = questionario.Id;
            }
            else
                throw new ArgumentException("", "Código de acesso invalido");
        }
        public void DestravarQuestionario()
        {

            this.Acesso = true;
            this.Refez = false;
            var questionarioUsuarioDAO = new QuestionarioUsuarioDAO();

            if(VerificarSeJaFoiDestravado(questionarioUsuarioDAO))
                questionarioUsuarioDAO.Adicionar(this);
        }

        private bool VerificarSeJaFoiDestravado(QuestionarioUsuarioDAO questionarioUsuarioDAO)
        {
            var query = questionarioUsuarioDAO.QuestionarioUsuario().FirstOrDefault(x => x.UsuarioID == x.UsuarioID && x.QuestionarioID == QuestionarioID);
            if (query != null)
                throw new Exception("Questionario já destravado");
            else return true;
        }
    }
}
