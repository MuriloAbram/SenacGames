using System;
using System.Collections.Generic;
using System.Text;

// DTO de categoria, para ser usado na horda de cadastrar um jogo, para o usuario selecionar a categoria do jogo
namespace SenacGames.Application.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int GameCount { get; set; } // Quantidade de jogos nessa categoria. Util pra mostar na dashbord e na listagem
    }

    //Dto para criação de uma nova categoria
    public class  CreateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }

    // Dto para atualização de uma categoria existente.
    public class UpdateCategoryDto
    {
        public string Name { get; set; } = string.Empty;
    }
}