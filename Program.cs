using System;

namespace MathLibraryDemo
{
    class Program
    {
        static void Main()
        {
            // === Vector tests ===
            var v1 = new Vector3D(1, 2, 3);
            var v2 = new Vector3D(4, 5, 6);

            Console.WriteLine("Vector Operations:");
            Console.WriteLine($"{v1} + {v2} = {v1 + v2}");
            Console.WriteLine($"{v1} - {v2} = {v1 - v2}");
            Console.WriteLine($"Dot({v1}, {v2}) = {Vector3D.Dot(v1, v2)}");
            Console.WriteLine($"Cross({v1}, {v2}) = {Vector3D.Cross(v1, v2)}");

            // === Matrix tests ===
            var scale = Matrix4x4.Scaling(2, 2, 2);
            var rotation = Matrix4x4.RotationZ((float)Math.PI / 4); // 45 degrees

            var transform = scale * rotation;
            var v = new Vector3D(1, 0, 0);

            var result = transform.Transform(v);

            Console.WriteLine("\nMatrix Transformations:");
            Console.WriteLine($"Original vector: {v}");
            Console.WriteLine($"After scaling+rotation: {result}");
        }
    }
}
