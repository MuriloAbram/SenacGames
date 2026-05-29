using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SenacGames.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SenacGames.Infrastructure.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(g => g.Id); // Chave primaria

            builder.Property(g => g.Title) // Campo Title ou nome
                .IsRequired() //Define que o campo é obrigatório
                .HasMaxLength(200); // Define o tamanho máximo do campo

            builder.Property(g => g.Description)
                .HasMaxLength(2000);

            builder.Property(g => g.CoverImageUrl)
                .HasMaxLength(2000);

            builder.HasOne(g => g.Category) // Um game tem uma categoria
                .WithMany(c => c.Games) // Uma categoria tem muitos games
                .HasForeignKey(g => g.CategoryId) // Chave estrangeira para a categoria
                .OnDelete(DeleteBehavior.Restrict); // Impede que a exclusão de uma categoria exclua os jogos associados
        }
    }
}
