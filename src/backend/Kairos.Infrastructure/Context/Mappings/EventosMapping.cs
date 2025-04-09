namespace Kairos.Infrastructure.Context.Mappings;
public class EventosMapping : IEntityTypeConfiguration<EventosEntity>
{
    public void Configure(EntityTypeBuilder<EventosEntity> builder)
    {
        builder.ToTable("Tbl_Eventos");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).
                IsRequired(true).
                HasMaxLength(100).
                HasColumnType("NVARCHAR");
        builder.Property(x => x.Descricao).
                IsRequired(true);
        builder.Property(x => x.DataHora).
                IsRequired(true);
        builder.Property(x => x.Local).
                IsRequired(true);
        builder.Property(x => x.Foto).
                IsRequired(true);
        builder.Property(x => x.TipoEventoId).
                IsRequired(true);
        builder.HasOne(x => x.TipoEvento).WithMany(x => x.Eventos).HasForeignKey(x => x.TipoEventoId).HasConstraintName("FK_TipoEvento_Eventos").OnDelete(DeleteBehavior.Cascade);
    }
}
