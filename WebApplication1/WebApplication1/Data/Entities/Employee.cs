namespace WebApplication1.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string lastName { get; set; }


        public class PartTimeEmployee : Employee
        {
            public decimal HourlyWage { get; set; }
        }
    
        public class FullTimeEmployee : Employee
        {
            public decimal DailyWage { get; set; }
        }

    }
}
