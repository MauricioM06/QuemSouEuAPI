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

            eu.Nome = "Yaritza";
            eu.Sobrenome = "Silva";
            eu.UsuarioGitHub = "YaritzaSilva";

            return eu;
        }
    }
}