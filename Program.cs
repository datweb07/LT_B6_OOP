using System;
using System.Collections.Generic;

namespace CS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vector3D> vectors = new List<Vector3D>
        {
            new Vector3D(3, 2, 1),
            new Vector3D(4, 5, 6),
            new Vector3D(4, 3, 4),
            new Vector3D(0, 0, 0),
            new Vector3D(1, 1, 1)
        };


            Console.WriteLine("Danh sách các vector:");
            for (int i = 0; i < vectors.Count; i++)
            {
                Console.WriteLine($"Vector {i + 1}: {vectors[i]}");
                Console.WriteLine($"  Độ dài: {vectors[i].Length():F3}");

                try
                {
                    string normalized = vectors[i].Normalize();
                    Console.WriteLine($"  Tổ hợp tuyến tính: {normalized}");
                }
                catch (UndefinedOrientationException ex)
                {
                    Console.WriteLine($"  Lỗi biểu diễn tổ hợp tuyến tính: {ex.Message}");
                }
                Console.WriteLine();
            }

            Console.WriteLine(" KIỂM THỬ TÍNH GÓC GIỮA CÁC VECTOR \n");

            for (int i = 0; i < vectors.Count - 1; i++)
            {
                for (int j = i + 1; j < vectors.Count; j++)
                {
                    try
                    {
                        double angle = vectors[i] % vectors[j];
                        Console.WriteLine($"Góc giữa vector {vectors[i]} và {vectors[j]}: {Vector3D.RadianToDegree(angle):F1}°");
                    }
                    catch (UndefinedOrientationException ex)
                    {
                        Console.WriteLine($"Lỗi tính góc giữa {vectors[i]} và {vectors[j]}: {ex.Message}");
                    }
                }
            }
        }
    }

}
