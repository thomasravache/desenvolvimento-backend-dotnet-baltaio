using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Blog.Models;
using Microsoft.IdentityModel.Tokens;

namespace Blog.Services;

public class TokenService
{
    public string GenerateToken(User user)
    {
        var tokenHandler = new JwtSecurityTokenHandler(); // Cria instancia do manipulador de token (espera a chave convertida  em um array de bytes)
        var key = Encoding.ASCII.GetBytes(Configuration.JwtKey); // converte a chave pra um array de bytes
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, "thomasravache"), // User.Identity.Name
                new Claim(ClaimTypes.Role, "admin"), // User.IsInRole
                new Claim("fruta", "banana")
            }),
            Expires = DateTime.UtcNow.AddHours(8), // tempo de expiração do token
            SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(key), // usada para desencriptar e encriptar
                SecurityAlgorithms.HmacSha256Signature // Algoritmo utilizado
            ) // forma como vai gerar o token e encriptá-lo / desencriptá-lo
        };
        var token = tokenHandler.CreateToken(tokenDescriptor); // cria o token baseado nas opções do tokenDescriptor

        return tokenHandler.WriteToken(token); // retornará uma string baseada no token
    }
}