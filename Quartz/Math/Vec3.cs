namespace Quartz.Math
{
    public struct Vec3
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Vec3(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vec3 operator +(Vec3 a, Vec3 b)
        {
            return new Vec3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public static Vec3 operator -(Vec3 vec)
        {
            return new Vec3(-vec.X, -vec.Y, -vec.Z);
        }

        public static Vec3 operator -(Vec3 a, Vec3 b)
        {
            return a + -b;
        }

        public static Vec3 operator *(Vec3 a, double scalar)
        {
            return new Vec3(a.X * scalar, a.Y * scalar, a.Z * scalar);
        }

        public static Vec3 operator *(double scalar, Vec3 a)
        {
            return a * scalar;
        }

        public static Vec3 operator *(Vec3 a, Vec3 b)
        {
            return new Vec3(a.X * b.X, a.Y * b.Y, a.Z * b.Z);
        }

        public double LengthSquared()
        {
            return X * X + Y * Y + Z * Z;
        }

        public double Length()
        {
            return System.Math.Sqrt(LengthSquared());
        }

        public Vec3 Normalized()
        {
            return this * (1D / Length());
        }
    }
}
