namespace exercise_1
{
    public class TwoFourSideLinkedCrossroadsFactory : ICrossroadsFactory
    {
        private IRoadsFactory _firstRoadFactory;

        private IRoadsFactory _secondRoadFactory;

        public TwoFourSideLinkedCrossroadsFactory(IRoadsFactory firstRoadFactory, IRoadsFactory secondRoadFactory)
        {
            _firstRoadFactory = firstRoadFactory;
            _secondRoadFactory = secondRoadFactory;
        }

        public IEnumerable<Crossroad> CreateLinkedCrossroads()
        {
            Crossroad crossroad1 = new Crossroad(_firstRoadFactory);
            Crossroad crossroad2 = new Crossroad(_secondRoadFactory);
            return new List<Crossroad>()
            {
                crossroad1,
                crossroad2
            };
        }
    }
}