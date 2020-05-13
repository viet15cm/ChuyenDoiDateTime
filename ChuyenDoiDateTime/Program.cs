using System;

namespace ChuyenDoiDateTime
{
    class Program
    {
        static string dateTime(string xau)
        {
            string a, b;
            DateTime dtt = Convert.ToDateTime(xau);
            int dd, mm, yy;
            dd = dtt.Day;
            mm = dtt.Month;
            yy = dtt.Year;
            if (dd < 10)
                a = "0" + dd.ToString();
            else a = dd.ToString();
            if (mm < 10)
                b = "0" + mm.ToString();
            else b = mm.ToString();
            return b + "/" + a + "/" + yy.ToString(); ;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(dateTime("3/4/1995"));
            
            Console.WriteLine("Hello World!");
        }
    }
}
