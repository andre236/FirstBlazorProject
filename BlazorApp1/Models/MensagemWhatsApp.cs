namespace BlazorApp1.Models
{
    public class MensagemWhatsApp : IMensagem
    {
        public bool Enviar(string msg)
        {
            return true;
        }
    }
}
