namespace StudentAdminPortalAPI.DataModels
{
    public class Address
    {
        public Guid Id { get; set; }
        public string PhysicalAddrss { get; set; }
        public string PostalAddress { get; set; }

        //navigation property

        public Guid StudentId { get; set; }
    }
}
