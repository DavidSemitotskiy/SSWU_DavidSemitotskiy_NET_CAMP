namespace exercise_1
{
    public static class FenceBuilder
    {
        public static List<Fence> BuildFence(List<Tree> trees)
        {
            if (trees == null || trees.Count < 3)
            {
                throw new ArgumentException("Three or more trees are required to build fence");
            }

            List<Fence> fences = new List<Fence>();
            Point pointInHull = FindMostLeftTreeCoordinates(trees);
            Point nextPoint;
            Orientation orientation;
            do
            {
                fences.Add(new Fence(pointInHull));
                nextPoint = trees[0].Situation;
                foreach (Tree tree in trees)
                {
                    orientation = Point.GetOrientation(pointInHull, nextPoint, tree.Situation);
                    if (nextPoint == pointInHull || orientation == Orientation.CounterClockWise ||
                        (orientation == Orientation.Collinear && Point.Distance(pointInHull, tree.Situation) > Point.Distance(pointInHull, nextPoint)))
                    {
                        nextPoint = tree.Situation;
                    }
                }

                pointInHull = nextPoint;
            }
            while (pointInHull != fences[0].Situation);
            return fences;
        }

        private static Point FindMostLeftTreeCoordinates(List<Tree> trees)
        {
            Point maxPoint = trees[0].Situation;
            for (int i = 1; i < trees.Count; i++)
            {
                if (trees[i].Situation.X < maxPoint.X)
                {
                    maxPoint = trees[i].Situation;
                }
            }

            return maxPoint;
        }
    }
}
