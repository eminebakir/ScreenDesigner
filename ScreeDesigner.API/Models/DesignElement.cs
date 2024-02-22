namespace ScreeDesigner.API.Models
{
    public class DesignElement
    {
        public Guid DesignElementId { get; set; }
        public string? Name { get; set; }
        public List<Property>? Properties { get; set; }
    }
}
