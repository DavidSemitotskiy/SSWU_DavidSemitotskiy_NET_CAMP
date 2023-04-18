namespace exercise_1
{
    public class Garden
    {
        private List<Tree> _trees;

        private List<Fence> _fences;

        private double _totalDistanceFence;

        public Garden(List<Tree> trees)
        {
            _trees = trees;
            _fences = FenceBuilder.BuildFence(_trees);
            _totalDistanceFence = CountTotalDistanceFence();
        }

        public double TotalDistanceFence => _totalDistanceFence;

        private double CountTotalDistanceFence()
        {
            double totalDistance = 0;
            for (int i = 0; i < _fences.Count - 1; i++)
            {
                totalDistance += Point.Distance(_fences[i].Situation, _fences[i + 1].Situation);
            }

            totalDistance += Point.Distance(_fences[_fences.Count - 1].Situation, _fences[0].Situation);
            return totalDistance;
        }
    }
}
