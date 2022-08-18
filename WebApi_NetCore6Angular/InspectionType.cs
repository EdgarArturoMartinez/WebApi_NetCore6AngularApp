using System.ComponentModel.DataAnnotations;

namespace WebApi_NetCore6Angular
{
    public class InspectionType
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string InspectionName { get; set; }  
    }
}
