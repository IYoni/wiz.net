

namespace homiepure.wizard.Models
{
    // This class represents any database object: table, field, view, function, storedprocedure
    public class SchemaDefinition
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public bool IsAffected { get; set; }
        public bool IsExists { get; set; }
        public int Priority { get; set; }
        public string Parent { get; set; }
        public object Child { get; set; }
    }
}
