namespace exercise_1
{
    //інтерфейс для реалізації світлофору
    public interface ITrafficLight : ICloneable
    {
        public string Name { get; }

        public void SwitchState();
    }
}