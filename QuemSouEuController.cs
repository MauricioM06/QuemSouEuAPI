using Microsoft.AspNetCore.Mvc;
using QuemSouEuAPI.Models;

namespace QuemSouEuAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuemSouEuController : ControllerBase
    {
        [HttpGet]
        public PessoaModel Get()
        {
            PessoaModel eu = new PessoaModel();

            eu.Nome = "Maurício";
            eu.Sobrenome = "Moura";
            eu.UsuarioGitHub = "MauricioM06";

            return eu;
        }
    }
}
