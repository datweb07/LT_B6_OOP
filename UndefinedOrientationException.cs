namespace CS
{
    public class UndefinedOrientationException : Exception
    {
        public UndefinedOrientationException() : base("Không thể biểu diễn vector 0") {}
        public UndefinedOrientationException(string message) : base(message) { }

        public static bool CheckNullVector(Vector3D v)
        {
            if (v == null)
            {
                return true;
            }
            return (v.X == 0 && v.Y == 0 && v.Z == 0);
        }
    }
}