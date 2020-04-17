using Walker.API.Enums;

namespace Walker.API.Model
{
    public class Lead
    {
        public int LeadId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string ZipCode { get; set; }
        public ContactPermission ContactPermission { get; set; }
        #nullable enable
        public string? Email { get; set; }
    }
}
