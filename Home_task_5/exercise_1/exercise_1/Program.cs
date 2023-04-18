namespace exercise_1
{
    public class Program
    {
        public static void Main()
        {
            List<Tree> firstGardenTrees = new List<Tree>()
            {
                new Tree(new Point(0, 2)),
                new Tree(new Point(1, 0)),
                new Tree(new Point(3, 1)),
                new Tree(new Point(5, 1)),
                new Tree(new Point(2, 2)),
                new Tree(new Point(1, 4)),
                new Tree(new Point(2, 6)),
                new Tree(new Point(3, 4)),
                new Tree(new Point(5, 5)),
                new Tree(new Point(4, 3))
            };

            Garden firstGarden = new Garden(firstGardenTrees);
            Console.WriteLine(firstGarden.TotalDistanceFence);

            List<Tree> secondGardenTrees = new List<Tree>()
            {
                new Tree(new Point(2, 1)),
                new Tree(new Point(1, 4)),
                new Tree(new Point(4, 4)),
                new Tree(new Point(7, 2)),
                new Tree(new Point(6, 6)),
                new Tree(new Point(4, 7)),
                new Tree(new Point(7, 8)),
                new Tree(new Point(3, 8)),
                new Tree(new Point(2, 9)),
                new Tree(new Point(6, 10))
            };

            Garden secondGarden = new Garden(secondGardenTrees);
            Console.WriteLine(secondGarden.TotalDistanceFence);

            Console.WriteLine(firstGarden.Equals(secondGarden));
            Console.WriteLine(firstGarden.CompareTo(secondGarden));
            Console.WriteLine(firstGarden == secondGarden);
            Console.WriteLine(firstGarden != secondGarden);
            Console.WriteLine(firstGarden > secondGarden);
            Console.WriteLine(firstGarden < secondGarden);
            Console.WriteLine(firstGarden >= secondGarden);
            Console.WriteLine(firstGarden <= secondGarden);
        }
    }
}