using System;
using Genesys.Workspace.Model;

namespace Genesys.Workspace.Model
{
    public class Transaction
    {
        public string name { get; set; }
        public string alias { get; set; }
        public KeyValueCollection userProperties { get; set; }

        public override string ToString()
        {
            return string.Format("[Transaction: name={0}, alias={1}, userProperties={2}]", name, alias, userProperties);
        }
    }
}
