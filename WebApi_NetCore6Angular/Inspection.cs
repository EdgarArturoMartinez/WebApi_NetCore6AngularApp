using System.ComponentModel.DataAnnotations;

namespace WebApi_NetCore6Angular
{
    public class Inspection
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = string.Empty;

        [StringLength(20)]
        public string Comments { get; set; } = string.Empty;

        public int InspectionTypeId { get; set; }

        public InspectionType? inspectionType { get; set; }


    }
}
