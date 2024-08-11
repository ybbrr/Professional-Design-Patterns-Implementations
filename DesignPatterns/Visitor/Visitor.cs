namespace DesignPatterns.Visitor
{

    /*
      * Çok kullanışlıdır. Visitor Design Pattern birbirine benzeyen veya hiyerarşik nesnelerin biri üzerinden diğerlerinin de 
        çağırılmasını sağlar. Bir şikketteki bütün hiyerarşinin maaşının artırılacağını hayal edin.
        Bunun için bir hiyerarşik model kurabilirsiniz ama Visitor Design Pattern'de amaç aynı desen kullanarak hiyerarşinin 
        en tepesinden en aşağısına kadar diğer nesnelerin sürdürülmesini sağlamaktır.
      * Burada bu konuyu anlatırken şirketin en üst yetkilisinden en alt yetkilisine ziyaret yapıldığını farzedin.
    */

    public abstract class EmployeeBase
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public abstract void Accept(VisitorBase visitor);
    }

    public class Manager : EmployeeBase
    {
        /*Manager'ın altında çalışan insanlar olur*/
        public List<EmployeeBase> Subordinates { get; set; }

        public Manager()
        {
            Subordinates = new List<EmployeeBase>();
        }
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);

            foreach (var subordinate in Subordinates)
            {
                subordinate.Accept(visitor);
            }
        }
    }

    public class Worker : EmployeeBase
    {
        public override void Accept(VisitorBase visitor)
        {
            visitor.Visit(this);
        }
    }

    public abstract class VisitorBase
    {
        public abstract void Visit(Worker worker);
        public abstract void Visit(Manager manager);
    }

    public class PaymentlVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine($"Paid to {worker.Name} {worker.Salary}");
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine($"Paid to {manager.Name} {manager.Salary}");
        }
    }

    /*
      * Şimdi aşağıda maaş artışı özelliği olan PayRise class'ı tanımlanmıştır.
      * Gelecekte prim özelliği de eklemek için aşağıdaki gibi VisitorBase class'ından yararlanabiliriz.
    */
    public class PayRiseVisitor : VisitorBase
    {
        public override void Visit(Worker worker)
        {
            Console.WriteLine($"{worker.Name} salary increased to {worker.Salary * (decimal) 1.1}");
        }

        public override void Visit(Manager manager)
        {
            Console.WriteLine($"{manager.Name} salary increased to {manager.Salary * (decimal) 1.2}");
        }
    }

    public class OrganisationalStructure
    {
        public EmployeeBase Employee;

        public OrganisationalStructure(EmployeeBase firstEmployee)
        {
            Employee = firstEmployee;
        }

        public void Accept(VisitorBase visitor)
        {
            Employee.Accept(visitor);
        }
    }
}
