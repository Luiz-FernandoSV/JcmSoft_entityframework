using JcmSoft.Domain.DTOS;
using JcmSoft.Domain.Entities;
using JcmSoft.EFCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JcmSoft.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DepartamentosController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DepartamentoDTO>>> GetDepartamentos()
        {
            var resultado = await _context.Departamentos.Select(d => new DepartamentoDTO
            {
                DepartamentoId = d.DepartamentoId,
                Nome = d.Nome,
                Descricao = d.Descricao
            }).ToListAsync();
            return Ok(resultado);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<DepartamentoDTO>> GetDepartamentoById(int id){
            var departamento = await _context.Departamentos.AsNoTracking().FirstOrDefaultAsync(d => d.DepartamentoId == id);

            if(departamento is null) return NotFound("Nenhum departamento com este ID foi encontrado.");
            var departamentoDTO = new DepartamentoDTO
            {
                DepartamentoId = departamento.DepartamentoId,
                Nome = departamento.Nome,
                Descricao = departamento.Descricao
            };
            
            return Ok(departamentoDTO);
        }

        [HttpPost]
        public async Task<ActionResult<DepartamentoDTO>> CriarDepartamento(DepartamentoDTO dto)
        {
            var novoDepartamento = new Departamento
            {
                Nome = dto.Nome,
                Descricao = dto.Descricao
            };

            _context.Departamentos.Add(novoDepartamento);
            await _context.SaveChangesAsync();

            dto.DepartamentoId = novoDepartamento.DepartamentoId;

            return CreatedAtAction(nameof(GetDepartamentoById), new { id = dto.DepartamentoId }, dto);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> AtualizarDepartamento(DepartamentoDTO dto,int id)
        {
            if (id != dto.DepartamentoId)
            {
                return BadRequest($"Dados inválidos (id e objeto departamento)");
            }

            var departamento = await _context.Departamentos.FindAsync(id);

            if(departamento == null)
            {
                return NotFound("Departamento com o ID" + id + " não encontrado");
            }
            departamento.Nome = dto.Nome;
            departamento.Descricao = dto.Descricao;

            var DtoAtualizado = new DepartamentoDTO
            {
                DepartamentoId = departamento.DepartamentoId,
                Nome = departamento.Nome,
                Descricao = departamento.Descricao
            };

            await _context.SaveChangesAsync();
            return Ok(DtoAtualizado);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletarDepartamento(int id)
        {
            if(id <= 0)
            {
                return BadRequest("ID invalido");
            }

            var departamento = await _context.Departamentos.FindAsync(id);

            if(departamento is null)
            {
                return NotFound();
            }
            _context.Departamentos.Remove(departamento);
            await _context.SaveChangesAsync();

            return NoContent();

        }
    }
}
