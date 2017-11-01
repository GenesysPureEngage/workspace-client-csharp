using System;
using Genesys.Workspace.Model;

namespace Genesys.Workspace.Model
{
    public class User
    {
        public int dbid { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string userName { get; set; }
        public string employeeId { get; set; }
        public string agentId { get; set; }
        public string defaultPlace { get; set; }
        public int tenantDBID { get; set; }
        public KeyValueCollection userProperties { get; set; }

        public override string ToString()
        {
            return string.Format("[User: dbid={0}, firstName={1}, lastName={2}, userName={3}, employeeId={4}, agentId={5}, defaultPlace={6}, tenantDBID={7}, userProperties={8}]", dbid, firstName, lastName, userName, employeeId, agentId, defaultPlace, tenantDBID, userProperties);
        }
    }
}
