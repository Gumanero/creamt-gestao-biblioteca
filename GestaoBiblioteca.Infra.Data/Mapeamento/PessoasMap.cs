using GestaoBiblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoBiblioteca.Infra.Data.Mapeamento
{
    public class PessoasMap : MapBase<Pessoas>
    {
        public override void Configure(EntityTypeBuilder<Pessoas> builder)
        {
            base.Configure(builder);
            builder.ToTable("Pessoas");

            builder.HasKey(c => c.MatriculaId)
                   .HasName("movimentacao_Id");

            builder.Property(c => c.Nome)
                   .HasColumnName("nome")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.DadosPessoais)
                   .HasColumnName("dados_pessoais")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Endereco)
                   .HasColumnName("endereco")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Contato)
                   .HasColumnName("contato")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Tipo)
                   .HasColumnName("tipo");

            builder.Property(c => c.Situacao)
                   .HasColumnName("situação");

        }
    }
}