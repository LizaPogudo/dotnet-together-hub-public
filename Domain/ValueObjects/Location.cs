namespace Domain.ValueObjects
{
    public record Location
    {
        public string City { get; } = default!;
        public string Street { get; } = default!;
        public string Flat { get; } = default!;

        private Location(string city, string street)
        {
            City = city;
            Street = street;
        }

        public static Location Of(string city, string street)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(city);
            ArgumentException.ThrowIfNullOrWhiteSpace(street);

            return new Location(city, street);
        }
    }
}
