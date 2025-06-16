namespace BlazorApp1.Models
{
    public class MensagemEmail : IMensagem
    {
        public bool Enviar(string mensagem)
        {
            return true;
        }
    }
}
