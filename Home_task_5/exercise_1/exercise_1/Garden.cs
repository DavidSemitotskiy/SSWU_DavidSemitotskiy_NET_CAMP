namespace exercise_1
{
    public class Garden : IComparable<Garden>
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

        public static bool operator ==(Garden garden1, Garden garden2)
        {
            return garden1.Equals(garden2);
        }

        public static bool operator !=(Garden garden1, Garden garden2)
        {
            return !(garden1.Equals(garden2));
        }

        public static bool operator >(Garden garden1, Garden garden2)
        {
            return garden1.CompareTo(garden2) > 0;
        }

        public static bool operator <(Garden garden1, Garden garden2)
        {
            return garden1.CompareTo(garden2) < 0;
        }

        public static bool operator >=(Garden garden1, Garden garden2)
        {
            return garden1.CompareTo(garden2) >= 0;
        }

        public static bool operator <=(Garden garden1, Garden garden2)
        {
            return garden1.CompareTo(garden2) <= 0;
        }

        public int CompareTo(Garden? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (Equals(other))
            {
                return 0;
            }

            return _totalDistanceFence > other._totalDistanceFence ? 1 : -1;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj is not Garden) 
            {
                return false;
            }

            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return _totalDistanceFence.GetHashCode();
        }

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
