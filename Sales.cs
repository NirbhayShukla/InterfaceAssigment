using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAssignment
{

    interface YearlySales
    {
        public int AnnualSales();
    }

    abstract class Sales
    {
        int sales;

        public Sales(int sales)
        {
            this.sales = sales;
        }

        public int DailySales()
        {
            return sales;
        }

        public abstract int MonthlySales();
    }
    internal class SalesExecution:Sales,YearlySales
    {
        public SalesExecution(int sales) : base(sales) { }

        public override int MonthlySales()
        {
            return DailySales() * 30;
        }
        
        public int AnnualSales()
        {
            return MonthlySales() * 12;
        }

        public void display()
        {
            Console.WriteLine("Daily Sales = " + DailySales());
            Console.WriteLine("Monthly Sales = " + MonthlySales());
            Console.WriteLine("Annual Sales = " + AnnualSales());
        }
    }

    public class SolutionDisplay { 
        public static void Main(string[] args)
        {
            SalesExecution s = new SalesExecution(400);
            s.display();
        }
    }

}
