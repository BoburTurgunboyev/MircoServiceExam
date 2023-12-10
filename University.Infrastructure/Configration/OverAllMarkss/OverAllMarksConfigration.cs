using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace University.Infrastructure.Configration.OverAllMarks
{
    public class OverAllMarksConfigration : IEntityTypeConfiguration<Domain.Entities. OverAllMarks>
    {

        public void Configure(EntityTypeBuilder<Domain.Entities.OverAllMarks> builder)
        {

        }
    }
}
