using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientesFlori_Encue
{
    class Tablas
    {
        double[,] Edades = new double[4, 3];
        double[,] TablaFre = new double[3, 3];

        double[,] E1 = new double[5, 3];
        double[,] E2 = new double[6, 3];
        double[,] E3 = new double[4, 3];
        double[,] E4 = new double[4, 3];

        public Tablas()
        {
            Edades[0, 0] = 1;
            Edades[1, 0] = 2;
            Edades[2, 0] = 3;
            Edades[3, 0] = 4;

            Edades[0, 1] = 0;
            Edades[1, 1] = 0.33;
            Edades[2, 1] = 0.70;
            Edades[3, 1] = 0.88;

            Edades[0, 2] = 0.33;
            Edades[1, 2] = 0.70;
            Edades[2, 2] = 0.88;
            Edades[3, 2] = 1;

            // opcion 1

            E1[0, 0] = 5;
            E1[1, 0] = 12;
            E1[2, 0] = 27;
            E1[3, 0] = 41;
            E1[4, 0] = 55;

            E1[0, 1] = 0;
            E1[1, 1] = 0.08;
            E1[2, 1] = 0.23;
            E1[3, 1] = 0.35;
            E1[4, 1] = 0.70;

            E1[0, 2] = 0.08;
            E1[1, 2] = 0.23;
            E1[2, 2] = 0.35;
            E1[3, 2] = 0.70;
            E1[4, 2] = 1;

            // opcion 2

            E2[0, 0] = 3;
            E2[1, 0] = 9;
            E2[2, 0] = 18;
            E2[3, 0] = 31;
            E2[4, 0] = 48;
            E2[5, 0] = 55;

            E2[0, 1] = 0;
            E2[1, 1] = 0.05;
            E2[2, 1] = 0.1;
            E2[3, 1] = 0.24;
            E2[4, 1] = 0.38;
            E2[5, 1] = 0.70;

            E2[0, 2] = 0.05;
            E2[1, 2] = 0.1;
            E2[2, 2] = 0.24;
            E2[3, 2] = 0.38;
            E2[4, 2] = 0.70;
            E2[5, 2] = 1;

            // opcion 3

            E3[0, 0] = 7;
            E3[1, 0] = 21;
            E3[2, 0] = 45;
            E3[3, 0] = 55;

            E3[0, 1] = 0;
            E3[1, 1] = 0.05;
            E3[2, 1] = 0.15;
            E3[3, 1] = 0.8;

            E3[0, 2] = 0.05;
            E3[1, 2] = 0.15;
            E3[2, 2] = 0.8;
            E3[3, 2] = 1;

            // opcion 4

            E4[0, 0] = 4;
            E4[1, 0] = 10;
            E4[2, 0] = 37;
            E4[3, 0] = 55;

            E4[0, 1] = 0;
            E4[1, 1] = 0.04;
            E4[2, 1] = 0.13;
            E4[3, 1] = 0.72;

            E4[0, 2] = 0.04;
            E4[1, 2] = 0.13;
            E4[2, 2] = 0.72;
            E4[3, 2] = 1;

            // Frecuencia de visita

            TablaFre[0, 0] = 1;
            TablaFre[1, 0] = 2;
            TablaFre[2, 0] = 3;

            TablaFre[0, 1] = 0;
            TablaFre[1, 1] = 0.37;
            TablaFre[2, 1] = 0.72;

            TablaFre[0, 2] = 0.37;
            TablaFre[1, 2] = 0.72;
            TablaFre[2, 2] = 1;
        }

        public double CalcularEdad(double Ri)
        {
            for (int i = 0; i < 4; i++)
            {
                if (Edades[i, 1] <= Ri && Ri < Edades[i, 2])
                {
                    return Edades[i, 0];

                }
            }

            return 0;
        }

        public double CalcularCali(double A, double Ri)
        {
            if (A == 1)
            {

                for (int i = 0; i < 5; i++)
                {
                    if (E1[i, 1] <= Ri && Ri < E1[i, 2])
                    {
                        return E1[i, 0];

                    }
                }
            }

            if (A == 2)
            {

                for (int i = 0; i < 6; i++)
                {
                    if (E2[i, 1] <= Ri && Ri < E2[i, 2])
                    {
                        return E2[i, 0];

                    }
                }
            }

            if (A == 3)
            {

                for (int i = 0; i < 4; i++)
                {
                    if (E3[i, 1] <= Ri && Ri < E3[i, 2])
                    {
                        return E3[i, 0];

                    }
                }
            }

            if (A == 4)
            {

                for (int i = 0; i < 4; i++)
                {
                    if (E4[i, 1] <= Ri && Ri < E4[i, 2])
                    {
                        return E4[i, 0];

                    }
                }
            }

            return 0;


        }

        public double CalcularFrecuencia(double Ri)
        {
            for (int i = 0; i < 3; i++)
            {
                if (TablaFre[i, 1] <= Ri && Ri < TablaFre[i, 2])
                {
                    return TablaFre[i, 0];

                }
            }

            return 0;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "|| Encuesta de satisfaccion con el personal de cajas ||";
            Console.WriteLine("***SOLO EN CUESTION DE EL TIEMPO DE ATENCION Y ATENCION DEL PERSONAL DE CAJAS ***");

            int A, C1, Ne;
            double Rn, Mod, M, Xo;
            //A = Int16.Parse(Console.ReadLine());
            A = 211;
            //C1 = Int16.Parse(Console.ReadLine());
            C1 = 101;
            //Xo = Double.Parse(Console.ReadLine());
            Xo = 31;
            //M = Double.Parse(Console.ReadLine());
            M = 17001;
            //Ne = Int16.Parse(Console.ReadLine());
            Ne = 120;

            double[,] T = new double[Ne, 6];

            for (int i = 0; i < Ne; i++)
            {

                Mod = ((A * Xo) + C1) % M;
                Rn = (Mod / M);

                T[i, 0] = i + 1;
                T[i, 1] = (A * Xo);
                T[i, 2] = (A * Xo) + C1;
                T[i, 3] = Mod;
                T[i, 4] = Rn;
                T[i, 5] = Mod;
                Xo = Mod;

            }

            /*for (int i = 0; i < Ne; i++)
            {

                Console.WriteLine("\n" + "N:          " + T[i, 0]);
                Console.WriteLine("A * Xo:     " + T[i, 1]);
                Console.WriteLine("A * Xo + C: " + T[i, 2]);
                Console.WriteLine("Modulo:     " + T[i, 3]);
                Console.WriteLine("Rn:         " + T[i, 4]);
                Console.WriteLine("Xn:         " + T[i, 5]);

            }*/

            Queue Col = new Queue();

            for (int i = 0; i < Ne; i++)
            {

                Col.Enqueue(T[i, 4]);

            }

            Tablas Te = new Tablas();

            int Cali, Fre, N, Edad;
            int NVi = 0;
            int ED1 = 0, ED2 = 0, ED3 = 0, ED4 = 0, Calificacion = 0, Res1 = 0, Res2 = 0, Res3 = 0;

            Console.WriteLine("Rango de edades: (1) 0 - 17  (2) 18 - 39  (3) 40 - 64  (4) 65 o mas.");
            Console.Write("\nIntroduce en rango donde se encuentre su edad: ");
            Edad = int.Parse(Console.ReadLine());

            Console.Write("\nIntroduce la Calificacion que le darias a la atencion al personal de cajas: ");
            Cali = int.Parse(Console.ReadLine());

            Console.WriteLine("\nNivel con que visita la tienda: (1) Muy Poca  (2) Ocasional (3) Muy seguido.");
            Console.Write("\nIntroduce el nivel de frecuencia: ");
            Fre = int.Parse(Console.ReadLine());

            Console.Write("\nIntroduce el numero de experimentos: ");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("---");

            double[,] AC = new double[N, 8];

            for (int i = 0; i < N; i++)
            {
                string C;
                double D, R = 0;

                AC[i, 0] = i + 1;
                C = Col.Dequeue().ToString();
                D = double.Parse(C);
                AC[i, 1] = D;
                AC[i, 2] = Te.CalcularEdad(AC[i, 1]);

                if (AC[i, 2] >= Edad)
                {
                    R = R + 1;
                }

                C = Col.Dequeue().ToString();
                D = double.Parse(C);
                AC[i, 3] = D;
                AC[i, 4] = Te.CalcularCali(AC[i, 2], AC[i, 3]);

                if (AC[i, 4] >= Cali)
                {
                    R = R + 1;
                }

                C = Col.Dequeue().ToString();
                D = double.Parse(C);
                AC[i, 5] = D;

                AC[i, 6] = Te.CalcularFrecuencia(AC[i, 5]);

                if (AC[i, 6] >= Fre)
                {
                    R = R + 1;
                }

                AC[i, 7] = R;
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Experimento Num. : " + AC[i, 0]);
                Console.WriteLine("Ri: " + AC[i, 1]);
                Console.WriteLine("Edad: " + AC[i, 2]);
                Console.WriteLine("Ri: " + AC[i, 3]);
                Console.WriteLine("Calificacion: " + AC[i, 4]);
                Console.WriteLine("Ri: " + AC[i, 5]);
                Console.WriteLine("Nivel de visita frecuente: " + AC[i, 6]);
                Console.WriteLine("Resultado: " + AC[i, 7]);

                Console.WriteLine();
            }

            for (int i = 0; i < N; i++)
            {
                if (AC[i, 2] == 1)
                {
                    ED1 = ED1 + 1;
                }

                else if (AC[i, 2] == 2)
                {
                    ED2 = ED2 + 1;
                }

                else if (AC[i, 2] == 3)
                {
                    ED3 = ED3 + 1;
                }

                else if (AC[i, 2] == 4)
                {
                    ED4 = ED4 + 1;
                }

                if (AC[i, 4] >= Cali)
                {
                    Calificacion = Calificacion + 1;
                }

                if (AC[i, 7] <= 1)
                {
                    Res1 = Res1 + 1;
                }

                else if (AC[i, 7] == 2)
                {
                    Res2 = Res2 + 1;
                }

                else if (AC[i, 7] == 3)
                {
                    Res3 = Res3 + 1;
                }

                if (AC[i, 6] >= Fre)
                {
                    NVi = NVi + 1;
                }
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("\nExperimentos: " + N);
            Console.WriteLine("\nPersonas de Edad 1: " + ED1);
            Console.WriteLine("Personas de Edad 2: " + ED2);
            Console.WriteLine("Personas de Edad 3: " + ED3);
            Console.WriteLine("Personas de Edad 4: " + ED4);
            Console.WriteLine("\nPersonas con puntaje alto: " + Calificacion);
            Console.WriteLine("\nPersonas con visita muy frecuenta: " + NVi);
            Console.WriteLine("\nPersonas no satisfechas: " + Res1);
            Console.WriteLine("Personas con opinion 50/50: " + Res2);
            Console.WriteLine("Personas Satisfechas: " + Res3);
            Console.WriteLine("\n----------------------------------");

            Console.ReadKey();
        }
    }
}
