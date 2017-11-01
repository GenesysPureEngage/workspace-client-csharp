using System;
using Genesys.Workspace.Model;

namespace Genesys.Workspace.Model
{
    public class AgentGroup
    {
        public int dbid { get; set; }
        public string name { get; set; }
        public KeyValueCollection userProperties { get; set; }

        public override string ToString()
        {
            return string.Format("[AgentGroup: name={0}, dbid={1}, userProperties={2}]", name, dbid, userProperties);
        }
    }
}
