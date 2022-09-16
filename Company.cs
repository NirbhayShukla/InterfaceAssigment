namespace InterfaceAssignment
{
    interface GovtRules
    {
        public double EmployeePF(double Salary);
        public string LeaveDetails();
        public double Gratuity(float serviceCompleted, double baicSalary);
    }

    class TCS : GovtRules
    {
        private int empId;
        private string name, dept, desg;
        private double basicSalary;

        public TCS(int empId,string name,string dept,string desg,double basicSalary)
        {
            this.empId = empId;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public int EMPID
        {
            get { return empId; }
        }

        public string NAME
        {
            get { return name; }
        }

        public string DEPT
        {
            get { return dept; }
        }

        public string DESG
        {
            get { return desg; }
        }

        public double BASICSALARY
        {
            get { return basicSalary; }
        }

        public double EmployeePF(double Salary)
        {
            return (.12+.837) * Salary;
        }

        public string LeaveDetails()
        {
            return "1 day of Casual leave per month \n 12 days of Sick Leaves per year \n 10 days of Privelage Leave per year";
        }
        public double Gratuity(float serviceCompleted, double basicSalary)
        {
            if (serviceCompleted < 5) return 0;
            if (serviceCompleted >= 5 && serviceCompleted<10) return basicSalary;
            if(serviceCompleted >= 10 && serviceCompleted<20) return 2*basicSalary;
            return 3 * basicSalary;
        }

        public void show()
        {
            Console.WriteLine($"Employee ID = {empId} , Name= {name} , Department = {dept} , Designtion = {desg} , Salary = {basicSalary}");
            Console.WriteLine("PF = " + EmployeePF(basicSalary));
            Console.WriteLine(LeaveDetails());
        }

    }

    class Accenture : GovtRules
    {
        private int empId;
        private string name, dept, desg;
        private double basicSalary;

        public Accenture(int empId, string name, string dept, string desg, double basicSalary)
        {
            this.empId = empId;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
        }

        public int EMPID
        {
            get { return empId; }
        }

        public string NAME
        {
            get { return name; }
        }

        public string DEPT
        {
            get { return dept; }
        }

        public string DESG
        {
            get { return desg; }
        }

        public double BASICSALARY
        {
            get { return basicSalary; }
        }

        public double EmployeePF(double Salary)
        {
            return .24 * Salary;
        }

        public string LeaveDetails()
        {
            return "2 days of Casual leave per month \n 5 days of Sick Leaves per year \n 5 days of Privelage Leave per year";
        }
        public double Gratuity(float serviceCompleted, double basicSalary)
        {
            return 0;
        }

        public void show()
        {
            Console.WriteLine($"Employee ID = {empId} , Name= {name} , Department = {dept} , Designtion = {desg} , Salary = {basicSalary}");
            Console.WriteLine("PF = " + EmployeePF(basicSalary));
            Console.WriteLine(LeaveDetails());
        }
    }

    public class CompanyExecution
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID");
            int empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            string dept=Console.ReadLine();
            Console.WriteLine("Enter Employee Designation");
            string desg=Console.ReadLine();
            Console.WriteLine("Enter Employee Salary");
            double salary=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee's Years Of Service");
            float yos= float.Parse(Console.ReadLine());
            Accenture emp1 = new Accenture(empId, name, dept, desg, salary);
            emp1.show();
            Console.WriteLine("Gratuity = " + emp1.Gratuity(yos, emp1.BASICSALARY));
            TCS emp2 = new TCS(empId, name, dept, desg, salary);
            emp2.show();
            Console.WriteLine("Gratuity = " + emp2.Gratuity(yos, emp2.BASICSALARY));
        }
    }
}