using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YuceEgitim.Entites;

namespace YuceEgitim.Database
{
    public class UserConfiguration : BaseConfiguration<User>
    {

    }

    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasQueryFilter(p => !p.Silindi);
            builder.Property(x => x.Silindi).HasColumnName("Deleted");
        }
    }
}