namespace Three.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string SurnName { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public bool Fired { get; set; }
    }
    public enum Gender
    {
        女 = 0,
        男 = 1
    }
}
