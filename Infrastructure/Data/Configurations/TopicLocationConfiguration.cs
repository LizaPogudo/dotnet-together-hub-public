namespace Infrastructure.Data.Configurations
{
    public class TopicLocationConfiguration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> builder)
        {
            builder.OwnsOne(topic => topic.Location, location =>
                {
                    location.Property(l => l.City).HasColumnName("City");
                    location.Property(l => l.Street).HasColumnName("Street");
                });
        }
    }
}
