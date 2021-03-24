using GestaoBiblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoBiblioteca.Infra.Data.Mapeamento
{
    public class CategoriasMap : MapBase<Categorias>
    {
        public override void Configure(EntityTypeBuilder<Categorias> builder)
        {
            base.Configure(builder);
            builder.ToTable("categorias");

            builder.HasKey(c => c.CategoriaId)
                   .HasName("categoria_id");

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(10)");

            builder.Property(c => c.Situacao)
                   .HasColumnName("situação");
        }
    }
}
