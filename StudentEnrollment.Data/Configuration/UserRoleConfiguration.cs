using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentEnrollment.Data.Configuration
{
    public partial class CourseConfiguration
    {
        public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
        {
            public void Configure(EntityTypeBuilder<IdentityRole> builder)
            {
                builder.HasData
                    (
                       new IdentityRole
                       {
                           Name = "Adminstrator",
                           NormalizedName = "ADMINSTRATOR"
                       },

                       new IdentityRole
                       {
                           Name = "User",
                           NormalizedName = "USER"
                       }
                    );
            }
        }

    }
}
