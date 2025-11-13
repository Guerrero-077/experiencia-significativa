using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;
using Utilities.Email.Interfaces;

namespace Utilities.Email.Implements
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        public async Task SendExperiencesEmail(string emailReceptor, string recoveryCode)
        {
            var emailEmisor = _config["EmailSettings:SenderEmail"]!;
            var password = _config["EmailSettings:Password"]!;
            var host = _config["EmailSettings:SmtpServer"]!;
            var puerto = int.Parse(_config["EmailSettings:Port"]!);

            var smtpCliente = new SmtpClient(host, puerto)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(emailEmisor, password)
            };

            string asunto = "¡Recuperación de contraseña - Experiencias Significativas !";
            string cuerpoHtml = $@"
            <!DOCTYPE html>
            <html lang=""es"">
            <head>
            <meta charset=""UTF-8"">
            <title>Recuperación de Contraseña</title>
            </head>
            <body style=""font-family: 'Arial', sans-serif; background: #f4f4f4; padding: 40px;"">
            <div style=""max-width: 600px; margin: auto; background: white; padding: 30px; border-radius: 10px; box-shadow: 0 5px 15px rgba(33, 151, 201, 0.1);"">
            <h2 style=""color: #c995f4;"">Recupera tu contraseña</h2>
            <p style=""font-size: 16px; color: #2d3748;"">Hemos recibido una solicitud para restablecer tu contraseña.</p>
            <p style=""font-size: 16px; color: #2d3748;"">Tu código de verificación es:</p>
            <div style=""font-size: 28px; font-weight: bold; color: #5890d8; margin: 20px 0; text-align: center;"">
            {recoveryCode} 
            </div>
            <p style=""font-size: 14px; color: #5890d8;"">Este código tiene una validez de 10 minutos. Si no solicitaste este cambio, puedes ignorar este correo.</p>
            <br>
            <p style=""font-size: 12px; color: #5890d8; text-align: center;"">Experiencias Significativas © 2025</p>
            </div>
            </body>
            </html>";

            var mensaje = new MailMessage(emailEmisor, emailReceptor, asunto, cuerpoHtml)
            {
                IsBodyHtml = true
            };

            await smtpCliente.SendMailAsync(mensaje);
        }
    }
}