using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstComplexType
{
    //[ComplexType]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}