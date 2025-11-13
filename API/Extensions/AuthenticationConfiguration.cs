using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System.Text.Json;

namespace API.Extensions
{
    public static class AuthenticationConfiguration
    {
        public static void AddCustomAuthentication(IServiceCollection services, IConfiguration configuration)
        {
            var key = Encoding.UTF8.GetBytes(configuration["JwtConfig:Key"]);

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.RequireHttpsMetadata = true;
                    options.SaveToken = true;

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,

                        ValidIssuer = configuration["JwtConfig:Issuer"],
                        ValidAudience = configuration["JwtConfig:Audience"],
                        IssuerSigningKey = new SymmetricSecurityKey(key)
                    };

                    options.Events = new JwtBearerEvents
                    {
                        OnAuthenticationFailed = context =>
                        {
                            var response = context.Response;
                            response.ContentType = "application/json";
                            response.StatusCode = StatusCodes.Status401Unauthorized;

                            var message = context.Exception switch
                            {
                                SecurityTokenExpiredException => "Token expirado",
                                SecurityTokenInvalidSignatureException => "Firma inválida",
                                _ => "Autenticación fallida"
                            };

                            var problem = new
                            {
                                status = 401,
                                title = message,
                                detail = context.Exception.Message,
                                type = "https://httpstatuses.com/401"
                            };

                            return response.WriteAsync(JsonSerializer.Serialize(problem));
                        }
                    };
                });
        }
    }

}
