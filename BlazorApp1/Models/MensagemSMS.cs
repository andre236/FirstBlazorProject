﻿namespace BlazorApp1.Models
{
    public class MensagemSMS : IMensagem
    {
        public bool Enviar(string mensagem)
        {
            return true;
        }
    }
}
