using System;
namespace Genesys.Workspace.Model
{
    public class BusinessAttributeValue
    {
        public long dbid { get; set; }
        public String name { get; set; }
        public String displayName { get; set; }
        public String description { get; set; }
        public Object defaultValue { get; set; }

        public override string ToString()
        {
            return string.Format("[BusinessAttributeValue: dbid={0}, name={1}, displayName={2}, description={3}, defaultValue={4}]", dbid, name, displayName, description, defaultValue);
        }
    }
}
