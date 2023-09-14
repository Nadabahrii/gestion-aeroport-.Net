using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Infrastructure.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(t => new
            {
                t.passengerfk,
                t.flightfk,
                t.numTicket
            });
            builder.HasOne(t => t.passenger).WithMany(p => p.tickets).HasForeignKey(t => t.passengerfk);
            builder.HasOne(t => t.flight).WithMany(f => f.tickets).HasForeignKey(t => t.flightfk);


        }
    }
}
