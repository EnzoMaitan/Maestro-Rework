using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maestro_Rework.Classes.Entidades;
using Maestro_Rework.DAO;

namespace Maestro_Rework.Classes
{
    public class ResultadoQuestionario
    {
        Usuario usuario;
        Questionario questionario;

        public ResultadoQuestionario(Usuario usuario, Questionario questionario)
        {
            this.usuario = usuario;
            this.questionario = questionario;
        }

        public double GetNota()
        {
            double nota = 0;
            QuestionarioUsuario questionarioUsuario = GetQuestaoUsuario();

            var questoesCorretas = GetQuestoesCorretas(questionarioUsuario);

            List<Alternativa> alternativas = GetAlternativas(questoesCorretas);

            List<Questao> questoes = GetQuestoes(alternativas);

            foreach (var questao in questoes)
            {
                nota += questao.Valor;
            }
            return nota;
        }

        private static List<Questao> GetQuestoes(List<Alternativa> alternativas)
        {
            List<Questao> questoes = new List<Questao>();
            var questaoDAO = new QuestaoDAO();

            foreach (var alternativa in alternativas)
            {
                questoes.Add(questaoDAO.Questoes().FirstOrDefault(x => x.Id == alternativa.QuestaoID));
            }

            return questoes;
        }

        private static List<Alternativa> GetAlternativas(List<AlternativaCorreta> questoesCorretas)
        {
            var alternativas = new List<Alternativa>();
            var alternativaDAO = new AlternativaDAO();

            foreach (var questao in questoesCorretas)
            {
                alternativas.Add(alternativaDAO.Alternativas().FirstOrDefault(x => x.Id == questao.AlternativaID));
            }

            return alternativas;
        }

        private static List<AlternativaCorreta> GetQuestoesCorretas(QuestionarioUsuario questionarioUsuario)
        {
            var alternativaCorretaDAO = new AlternativaCorretaDAO();
            return alternativaCorretaDAO
                   .alternativaCorretas().Where(
                   x => x.QuestionarioUsuarioID == questionarioUsuario.Id
                   ).ToList();
        }

        private QuestionarioUsuario GetQuestaoUsuario()
        {
            var questionarioUsuarioDAO = new QuestionarioUsuarioDAO();
            var questionarioUsuario = questionarioUsuarioDAO
                .QuestionarioUsuario().FirstOrDefault(
                x => x.UsuarioID == usuario.Id
                && x.QuestionarioID == questionario.Id);
            return questionarioUsuario;
        }

        public int GetAcertos()
        {
            QuestionarioUsuario questionarioUsuario = GetQuestaoUsuario();

            return GetQuestoesCorretas(questionarioUsuario).Count();
        }
    }
}
