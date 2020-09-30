﻿using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Projeto_EduXSprint2.Contexts;
using Projeto_EduXSprint2.Domains;
using Projeto_EduXSprint2.Utills;

namespace EduX_Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        // Chamamos nosso contexto do banco
        EduXContext _context = new EduXContext();

        // Capturar as infos do token do appsettings.json
        // Definimos uma variável para percorrer nossos métodos com as configurações obtidas no appsettings.json
        private IConfiguration _config;

        // Definimos um método construtor para poder passar essas configs
        public LoginController(IConfiguration config)
        {
            _config = config;
        }
        private Usuario AuthenticateUser(Usuario login)
        {
            return _context.Usuario
                .Include(a => a.IdPerfilNavigation)
                .FirstOrDefault(u => u.Email == login.Email && u.Senha == login.Senha);
        }

        private string GenerateJSONWebToken(Usuario userInfo)
        {
                var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

                // Definimos nossas Claims (dados da sessão) para poderem ser capturadas
                // a qualquer momento enquanto o Token for ativo
                var claims = new[] {
                new Claim(JwtRegisteredClaimNames.NameId, userInfo.Nome),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                // Pegar info de permissao por escrito, ex: Padrão ou Administrador
                new Claim(ClaimTypes.Role, userInfo.IdPerfilNavigation.Permissao)
    };

                // Configuramos nosso Token e seu tempo de vida
                var token = new JwtSecurityToken
                (
                    _config["Jwt:Issuer"],
                    _config["Jwt:Issuer"],
                    claims,
                    expires: DateTime.Now.AddMinutes(120),
                    signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        // Usamos a anotação "AllowAnonymous" para 
        // ignorar a autenticação neste método, já que é ele quem fará isso
        /// <summary>
        /// Método que gera o token para login e a criptografia
        /// </summary>
        /// <param name="login">login do usuario</param>
        /// <returns>Retorna a resposta</returns>
        [HttpPost]
        public IActionResult Login([FromBody] Usuario login)
        {

            // Criptografamos antes de consultar com o banco
            login.Senha = Crypto.Criptografar(login.Senha, login.Email.Substring(0, 4));

            // Definimos logo de cara como não autorizado
            IActionResult response = Unauthorized();

            // Autenticamos o usuário da API
            var user = AuthenticateUser(login);
            if (user != null)
            {
                var tokenString = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

    }
}
