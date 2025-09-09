namespace CS
{
    public class Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }


        public Vector3D(double x = 0, double y = 0, double z = 0)
        {
            X = x;
            Y = y;
            Z = z;
        }


        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public string Normalize()
        {
            try
            {
                if (UndefinedOrientationException.CheckNullVector(this))
                {
                    throw new UndefinedOrientationException();
                }


                return $"3 vector: {X}i + {Y}j + {Z}k";
            }
            catch (UndefinedOrientationException)
            {
                return "Không thể biểu diễn vector 0";
            }
        }

        public double DotProduct(Vector3D other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }

        public static double operator %(Vector3D v1, Vector3D v2)
        {
            try
            {
                if (UndefinedOrientationException.CheckNullVector(v1) || UndefinedOrientationException.CheckNullVector(v2))
                {
                    throw new UndefinedOrientationException("Không thể tính góc với vector 0");
                }

                double length1 = v1.Length();
                double length2 = v2.Length();

                double dotProduct = v1.DotProduct(v2);
                double cosAngle = dotProduct / (length1 * length2);

                return Math.Acos(cosAngle);
            }
            catch (UndefinedOrientationException)
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }



        public static double RadianToDegree(double radian)
        {
            return radian * 180.0 / Math.PI;
        }
    }
}