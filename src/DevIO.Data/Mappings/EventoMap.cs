using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevIO.Data.Mappings
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(s => s.EventoID);

            builder.Property(e => e.title)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(e => e.color)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.url)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.start).HasColumnType("datetime");

            builder.Property(e => e.end).HasColumnType("datetime");

            builder.ToTable("Eventos");
        }
    }
}
