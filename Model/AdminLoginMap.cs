using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUDAPPLICATION.Model
{
    public class AdminLoginMap
    {
        public AdminLoginMap(EntityTypeBuilder<AdminLogin> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.UserName);
            entityTypeBuilder.Property(x => x.Email).IsRequired();
            entityTypeBuilder.Property(x => x.UserPassword).IsRequired();
        }

    }
}
