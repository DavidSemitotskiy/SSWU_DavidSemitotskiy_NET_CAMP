namespace exercise_3
{
    public class ApartmentInfo
    {
        public ApartmentInfo(int id, string address, string lastName)
        {
            Id = id;
            Address = address;
            LastName = lastName;
        }

        public int Id { get; init; }

        private string Address { get; init; }

        private string LastName { get; init; }
    }
}