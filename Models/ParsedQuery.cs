namespace SQLViz.Models
{
    public class ParsedQuery
    {
        public List<string> Tables { get; set; } = new List<string>();
        public List<TableRelationship> Relationships { get; set; } = new List<TableRelationship>();
    }
}
