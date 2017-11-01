using System;
using System.Collections.Generic;
using Genesys.Workspace.Common;

namespace Genesys.Workspace.Model
{
    public class Dn
    {
        public string number { get; set; }
        public string switchName { get; set; }
        public string agentId { get; set; }
        public string telephonyNetwork { get; set; }
        public AgentState agentState { get; set; }
        public AgentWorkMode workMode { get; set; }
        public string forwardTo { get; set; }
        public bool dnd { get; set; }
        public DnCapability[] capabilities { get; set; }

        public override string ToString()
        {
            return string.Format("[Dn: number={0}, switchName={1}, agentId={2}, telephonyNetwork={3}, agentState={4}, workMode={5}, forwardTo={6}, dnd={7}, capabilities={8}]", number, switchName, agentId, telephonyNetwork, agentState, workMode, forwardTo, dnd, CapabilitiesAsString(capabilities));
        }

        public string CapabilitiesAsString(DnCapability[] caps)
        {
            List<string> capabilities = new List<string>();

            if (caps != null)
            {
                foreach (DnCapability c in caps)
                {
                    capabilities.Add(c.ToString());
                }
            }

            return "[" + String.Join(",", capabilities) + "]";
        }
    }

}
