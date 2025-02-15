namespace SQLViz.Models
{
    public class TableRelationship
    {
        public string SourceTable { get; set; }
        public string SourceColumn { get; set; }
        public string TargetTable { get; set; }
        public string TargetColumn { get; set; }
        public string JoinType { get; set; }
    }
}
