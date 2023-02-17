using System.IdentityModel.Tokens.Jwt;
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
        var tokenDescriptor = new SecurityTokenDescriptor();
        var token = tokenHandler.CreateToken(tokenDescriptor); // cria o token baseado nas opções do tokenDescriptor

        return tokenHandler.WriteToken(token); // retornará uma string baseada no token
    }
}