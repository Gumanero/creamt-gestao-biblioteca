using GestaoBiblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoBiblioteca.Infra.Data.Mapeamento
{
    public class LivrosMap : MapBase<Livros>
    {
        public override void Configure(EntityTypeBuilder<Livros> builder)
        {
            base.Configure(builder);
            builder.ToTable("Livros");

            builder.HasKey(c => c.LivrosId)
                   .HasName("livros_id");

            builder.Property(c => c.ISBN)
                   .HasColumnName("isbn")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Titulo)
                   .HasColumnName("titulo")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Situacao)
                   .HasColumnName("situação");

            builder.Property(c => c.Autor)
                   .HasColumnName("autor")
                   .ValueGeneratedNever();

            builder.Property(c => c.Editora)
                   .HasColumnName("editora")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Edicao)
                   .HasColumnName("edicao")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Ano)
                   .HasColumnName("ano");

            builder.Property(c => c.Categoria)
                   .HasColumnName("categoria");

            builder.Property(c => c.Situacao)
                   .HasColumnName("situação");
        }
    }
}