using System;

namespace MathLibraryDemo
{
    public struct Vector3D
    {
        public float X, Y, Z;

        public Vector3D(float x, float y, float z)
        {
            X = x; Y = y; Z = z;
        }

        // Addition
        public static Vector3D operator +(Vector3D a, Vector3D b) =>
            new Vector3D(a.X + b.X, a.Y + b.Y, a.Z + b.Z);

        // Subtraction
        public static Vector3D operator -(Vector3D a, Vector3D b) =>
            new Vector3D(a.X - b.X, a.Y - b.Y, a.Z - b.Z);

        // Dot product
        public static float Dot(Vector3D a, Vector3D b) =>
            a.X * b.X + a.Y * b.Y + a.Z * b.Z;

        // Cross product
        public static Vector3D Cross(Vector3D a, Vector3D b) =>
            new Vector3D(
                a.Y * b.Z - a.Z * b.Y,
                a.Z * b.X - a.X * b.Z,
                a.X * b.Y - a.Y * b.X
            );

        public override string ToString() =>
            $"({X}, {Y}, {Z})";
    }
}
