using System;
using System.Collections.Generic;

namespace Genesys.Workspace.Model
{
    public class BusinessAttribute
    {
        public int dbid { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public string description { get; set; }
        public List<BusinessAttributeValue> values { get; set; }

        public override string ToString()
        {
            return string.Format("[BusinessAttribute: dbid={0}, name={1}, displayName={2}, description={3}, values={4}]", dbid, name, displayName, description, ValuesAsString(values));
        }

        public string ValuesAsString(List<BusinessAttributeValue> values)
        {
            string response = "[\n";

            foreach(var value in values)
            {
                response += value.ToString() + "\n";
            }

            response += "]";

            return response;
        }
    }
}
