using Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class AtividadeController : Controller
    {
        private readonly IServicoGerenciamentoAtividades<IAtividade> _servicoGerenciamentoAtividades;

        public AtividadeController(IServicoGerenciamentoAtividades<IAtividade> servicoGerenciamentoAtividades)
        {
            _servicoGerenciamentoAtividades = servicoGerenciamentoAtividades;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var _atividades = _servicoGerenciamentoAtividades.ExibirListas();
            return Ok(_atividades);
        }

        [HttpPost]
        [Route("Estudo")]
        public IActionResult Post([FromBody] Estudo atividade)
        {
            _servicoGerenciamentoAtividades.Adicionar(atividade);
            return Ok(atividade);
        }

        [HttpPost]
        [Route("Lazer")]
        public IActionResult Post([FromBody] Lazer atividade)
        {
            _servicoGerenciamentoAtividades.Adicionar(atividade);
            return Ok(atividade);
        }

        [HttpPost]
        [Route("Trabalho")]
        public IActionResult Post([FromBody] Trabalho atividade)
        {
            _servicoGerenciamentoAtividades.Adicionar(atividade);
            return Ok(atividade);
        }

        [HttpPut]
        [Route("{nome}/{id}")]
        public IActionResult Put([FromRoute] string nome, [FromRoute] int id)
        {
            var atividade = _servicoGerenciamentoAtividades.Concluir(id, nome);
            return Ok(atividade);
        }
    }
}
