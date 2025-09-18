using System;

namespace MathLibraryDemo
{
    public class Matrix4x4
    {
        public float[,] M = new float[4, 4];

        // Identity matrix
        public static Matrix4x4 Identity()
        {
            var mat = new Matrix4x4();
            for (int i = 0; i < 4; i++)
                mat.M[i, i] = 1;
            return mat;
        }

        // Scaling matrix
        public static Matrix4x4 Scaling(float sx, float sy, float sz)
        {
            var mat = Identity();
            mat.M[0, 0] = sx;
            mat.M[1, 1] = sy;
            mat.M[2, 2] = sz;
            return mat;
        }

        // Rotation around Z axis
        public static Matrix4x4 RotationZ(float angleRadians)
        {
            var mat = Identity();
            float c = (float)Math.Cos(angleRadians);
            float s = (float)Math.Sin(angleRadians);

            mat.M[0, 0] = c; mat.M[0, 1] = -s;
            mat.M[1, 0] = s; mat.M[1, 1] = c;
            return mat;
        }

        // Matrix multiplication
        public static Matrix4x4 operator *(Matrix4x4 a, Matrix4x4 b)
        {
            var result = new Matrix4x4();
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    for (int k = 0; k < 4; k++)
                        result.M[i, j] += a.M[i, k] * b.M[k, j];
            return result;
        }

        // Multiply matrix * vector (homogeneous coords)
        public Vector3D Transform(Vector3D v)
        {
            float[] res = new float[4];
            float[] vec = { v.X, v.Y, v.Z, 1 };

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    res[i] += M[i, j] * vec[j];

            return new Vector3D(res[0], res[1], res[2]);
        }
    }
}
