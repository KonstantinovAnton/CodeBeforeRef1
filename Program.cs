

// ------------------------------------ КОД ДО РЕФАКТОРИНГА ------------------------------------------------

using System;

namespace CodeBefore
{
    class absd1 // Непонятные названия перемнных
    {
        private double x1, y2, z3; // В названиях переменных содержутся цифры
        public absd1() { x1 = y2 = z3 = 0; }
        public absd1(double x, double y, double z = 0) { this.x1 = x; this.y2 = y; this.z3 = z; }
        public static absd1 operator +(absd1 op1, absd1 op2)
        {
                     absd1 Result = new absd1();                    // отсутсвует нормальная табуляция
             Result.x1 = op1.x1+op2.x1; Result.y2 =op1.y2 + op2.y2;    // названия переменных в неверном регистре
            Result.z3 = op1.z3+op2.z3; return Result;
        }
        public static absd1 operator +(absd1 op1, double op2)      // в коде нет комментариев 
        {
            absd1 result = new absd1();
            result.x1 =op1.x1+ op2;
            result.y2 =op1.y2+ op2;
            result.z3 =op1.z3+ op2;
            return result;
        }
        public static absd1 operator +(double op1, absd1 op2)
        {



            absd1 result = new absd1();result.x1 = op2.x1 + op1;
                 result.y2 = op2.y2 + op1;result.z3 = op2.z3 + op1;
                     return result;


        }
        public static absd1 operator -(absd1 op)
        {


            absd1 result = new absd1(); result.x1 = -op.x1; result.y2 = -op.y2;
            result.z3 = -op.z3; return result;
        }
        public static bool operator <(absd1 op1, absd1 op2)
        {


            return (
                 Math.Sqrt(op1.x1*op1.x1+ op1.y2 *op1.y2 +op1.z3* op1.z3) <               // нету пробелом между операторами
             Math.Sqrt(op2.x1 *op2.x1 + op2.y2*op2.y2 +op2.z3 * op2.z3) ? true : false);
        }
        public static bool operator >(absd1 op1, absd1 op2)
        {
            return (
             Math.Sqrt(op1.x1 *op1.x1 +op1.y2* op1.y2+ op1.z3 *op1.z3) >
                     Math.Sqrt(op2.x1*op2.x1+op2.y2*op2.y2 +op2.z3* op2.z3) ? true : false);
        }
        public static bool operator true(absd1 op)
        {
    
            return op.x1 != 0 
                ||op.y2!=0||
                op.z3!=0?true : false;
        }
        public static bool operator false(absd1 op)
        {
            return op.x1 ==0 && op.y2 ==0 && op.z3 ==0?true : false;
        }
        public static bool operator |(absd1 op1,absd1 op2)
        {

            return op1.x1 * op2.x1 != 0 || op1.y2 * op2.y2 != 0 || op1.z3 * op2.z3 != 0 ? true : false;
        }
        public static bool operator &(absd1 op1,absd1 op2)
        {

            return op1.x1 *op2.x1 != 0 & op1.y2 * 
                op2.y2!=0 & op1.z3 * op2.z3 != 0 ? true : false;
        }
        public static bool operator !(absd1 op)
        {

            return op.x1 != 0|| op.y2 != 0 || op.z3 != 0 ? false : true;
        }
        public static implicit operator double(absd1 op1)
        {

            return op1.x1*op1.y2 * op1.z3;
        }
        public static explicit operator float(absd1 op1)
        {

            return (float)op1.x1*(float)op1.y2 * (float)op1.z3;
        }

        public override string ToString()
        {

            return this.x1 +", "+this.y2+ ", " + this.z3;
        }
    }
    internal class Program
    {
        private static void Main()
        {


            absd1 a = new absd1(1, 2, 3); absd1 b = new absd1(1, 1, 1);
            absd1 c = new absd1();
            Console.WriteLine("Координаты точки a: {0}",
                a.ToString());
            // Console.WriteLine("Координаты точки b: {0}", b.ToString());        // Есть закомментированные участки кода
            //Console.WriteLine("Координаты точки c: {0}", c.ToString());
            absd1 d = a + b + c; Console.WriteLine("A + B + C = {0}", d.ToString()); d = -a;
                 Console.WriteLine("D = -A = {0}", d.ToString());
            d += 1;
                    Console.WriteLine("D = -A + 1 = {0}", d.ToString());
            d = 1 + d;
                    Console.WriteLine("D = 1 + D = {0}", d.ToString());

            bool cond = a < b;
            Console.WriteLine("A < B = {0}", cond);
            cond = a > b;
            Console.WriteLine("A > B = {0}", cond);

            if (c) Console.WriteLine("Точка C истинна");    // операторы блоков if и else не обрамляются фигурными скобками
                    else Console.WriteLine("Точка C ложна");
            if (d) Console.WriteLine("Точка D истинна");
            else    Console.WriteLine("Точка D ложна");
            if  (a& d) Console.WriteLine("a & d истинно");
            else Console.WriteLine("a & d ложно");
            if(a | d) Console.WriteLine("a | d истинно");
            else Console.WriteLine("a | d ложно");
                    if (!c) Console.WriteLine("Точка !C истинна");
            else Console.WriteLine("Точка !C ложна");
                    double val = d * 2 + b;




                Console.WriteLine("d * 2 + b = " + val);
                float fval = (float)b * (float)Math.PI;
            Console.WriteLine("b * PI = " + fval);
             Console.ReadKey();




        }

    }
}


