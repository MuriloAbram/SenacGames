using SenacGames.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Text;


namespace SenacGames.Application.Interfaces
{
    // Contrato de serviço para operações relacionadas a jogos.
    // Define as operaqções de negocio disponiveis cd
    public interface IGameService
    {
        // Busca jogos e categorias
        Task<IEnumerable<GameDto>> GetAllAsync();
        Task<GameDto?> GetByIdAsync(int id);
        Task<IEnumerable<GameDto>> GetFeaturedAsync();
        Task<IEnumerable<GameDto?>> GetByCategoryAsync(int categoryId);

        // Criar, atualizar, deletar e contar jogos
        Task<GameDto> CreateAsync(CreateGameDto dto);
        Task<GameDto?> UpdateAsync(int id, UpdateGmeDto dto);
        Task<bool> DeleteAsync(int id);
        Task<int> CountAsync();
    }
}
