using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace UserApp.API.Service.Extensions
{
    public static class JwtBearerExtension
    {
        public static IServiceCollection AddJwtBearer(this IServiceCollection services) 
        {
            //definindo a politíca de autenticação do projeto
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
                .AddJwtBearer(options =>
                {
                    //definindo as preferências para autenticação com JWT
                    options.TokenValidationParameters = new TokenValidationParameters 
                    {
                        ValidateIssuer = true, //emissor do Token
                        ValidateAudience = true, //destinatário do Token
                        ValidateLifetime = true, //tempo de expiração do Token
                        ValidateIssuerSigningKey = true, // chave secreta utilizada pelo emissor do Token
                    };

                });
            return services;
        }
    }
}
