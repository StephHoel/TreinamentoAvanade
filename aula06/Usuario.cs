using System.Windows.Forms;

namespace aula06
{
    public class Usuario
    {
        // Atributos
        public string Nome  { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }


        // Construtor
        public Usuario()
        {
            this.Nome  = "";
            this.Email = "";
            this.Login = "";
            this.Senha = "";
        }

        public void ProvarExistencia()
        {
            MessageBox.Show($"Bem vindo, {this.Nome}");
        }
    }
}
