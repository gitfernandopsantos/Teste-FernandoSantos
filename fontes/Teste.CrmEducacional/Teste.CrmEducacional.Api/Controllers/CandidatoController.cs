using AutoMapper;
using Teste.CrmEducacional.Domain.Entities;
using Teste.CrmEducacional.DTO.DTOS;
using Teste.CrmEducacional.Repository.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Teste.CrmEducacional.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidatoController : ControllerBase
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly IMapper _mapper;
        public CandidatoController(ICandidatoRepository candidatoRepository, IMapper mapper)
        {
            _mapper = mapper;
            _candidatoRepository = candidatoRepository;

        }

        [HttpGet("BuscarTodosCandidatos")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult<List<Candidato>>> BuscarTodosCandidatos()
        {
            List<Candidato> candidatos = await _candidatoRepository.BuscarTodosCandidatos();

            if (candidatos.Count > 0 && candidatos != null)
            {
                var candidatoDto = _mapper.Map<IEnumerable<CandidatoDTO>>(candidatos);
                return Ok(candidatoDto);
            }
            else
            {
                return NotFound("Nenhum candidato foi encontrado.");
            }
        }

        [HttpGet("BuscarCandidatoPorId/{idCandidato}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> BuscarCandidatoPorId(long idCandidato)
        {
            try
            {
                var candidato = await _candidatoRepository.BuscarCandidatoPeloId(idCandidato);
                var candidatoDto = _mapper.Map<CandidatoDTO>(candidato);

                return Ok(candidatoDto);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
            catch (Exception)
            {
                return StatusCode(500, new { message = "Erro interno no servidor. Tente novamente mais tarde." });
            }
        }

        [HttpPost("AdicionarCandidato")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<CandidatoDTO>> AdicionarCandidato([FromBody] Candidato candidato)
        {
            var novoCandidato = await _candidatoRepository.AdicionarCandidato(candidato.Nome,candidato.Email,candidato.Telefone,candidato.CPF);
            if (novoCandidato != null)
            {
                var novoCandidatoDto = _mapper.Map<CandidatoDTO>(novoCandidato);
                return Ok(novoCandidatoDto);
            }
            else
            {
                return StatusCode(500, "Ocorreu um erro interno no servidor. Por favor, tente novamente mais tarde.");
            }
        }

        [HttpPut("AtualizarCandidato/{idCandidato}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Candidato>> AtualizarCandidato([FromBody] Candidato novoCandidato, long idCandidato)
        {
            Candidato candidato = await _candidatoRepository.AtualizarCandidato(idCandidato,novoCandidato.Nome,novoCandidato.Email,novoCandidato.Telefone,novoCandidato.CPF);
            return Ok(candidato);
        }
        [HttpDelete("DeletarCandidato/{idCandidato}")]
        public async Task<ActionResult<Candidato>> DeletarCandidato(long idCandidato)
        {
            bool candidatoDeletado = await _candidatoRepository.DeletarCandidato(idCandidato);
            if (candidatoDeletado != true)
            {
                return NoContent();
            }
            else
            {
                return Ok($"Candidato deletado com sucesso! Valor do resultado {candidatoDeletado}");
            }

        }

    }
}
