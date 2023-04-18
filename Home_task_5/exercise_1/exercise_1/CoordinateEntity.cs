namespace exercise_1
{
    public abstract class CoordinateEntity
    {
        protected Point _situation;

        public CoordinateEntity(Point point)
        {
            _situation = point.Clone() as Point;
        }

        public Point Situation => _situation.Clone() as Point;
    }
}