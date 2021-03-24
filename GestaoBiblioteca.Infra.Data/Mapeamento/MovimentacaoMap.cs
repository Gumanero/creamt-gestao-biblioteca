using GestaoBiblioteca.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GestaoBiblioteca.Infra.Data.Mapeamento
{
    public class MovimentacaoMap : MapBase<Movimentacao>
    {
        public override void Configure(EntityTypeBuilder<Movimentacao> builder)
        {
            base.Configure(builder);
            builder.ToTable("Movimentacao");

            builder.HasKey(c => c.MovimentacaoId)
                   .HasName("movimentacao_Id");

            builder.Property(c => c.Livro)
                   .HasColumnName("livro")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Cliente)
                   .HasColumnName("cliente")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.Profissional)
                   .HasColumnName("profissional")
                   .HasColumnType("varchar(100)");

            builder.Property(c => c.DataEmprestimo)
                   .HasColumnName("data_emprestimo");

            builder.Property(c => c.DataMaximaDevolucao)
                   .HasColumnName("data_maxima_devolucao");

            builder.Property(c => c.DataDevolucao)
                   .HasColumnName("data_devolucao");

            builder.Property(c => c.SituacaoEmprestimo)
                   .HasColumnName("situacao_emprestimo");
        }
    }
}