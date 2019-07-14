namespace Kangaroo
{
    public class Kangaroo
    {
        public int StartingPosition { get; private set; }
        public int JumpDistance { get; private set; }

        public Kangaroo(int startingPosition, int jumpDistance)
        {
            this.StartingPosition = startingPosition;
            this.JumpDistance = jumpDistance;
        }
    }
}
