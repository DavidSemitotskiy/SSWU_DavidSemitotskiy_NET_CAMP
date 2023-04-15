namespace exercise_3
{
    public class ElectricityService : IElectricityService
    {
        private IElectricityRepository _repository;

        public ElectricityService(IElectricityRepository repository)
        {
            _repository = repository;
        }

        public IElectricityRepository ElectricityRepository
        {
            get => _repository;
        }

        private string FormatDataToTable()
        {
            return "";
        }
    }
}