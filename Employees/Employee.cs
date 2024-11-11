using System.Runtime.Serialization;

namespace Employees
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Position { get; set; }

        [DataMember]
        public decimal Salary { get; set; }
    }
}