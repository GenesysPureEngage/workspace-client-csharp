using System;
using System.Collections.Generic;

namespace Genesys.Workspace.Model
{
    public class TargetSearchResult
    {
        public long TotalMatches { get; protected set; }
        public List<Target> Targets { get; protected set; }

        public TargetSearchResult(long totalMatches, List<Target> targets)
        {
            this.TotalMatches = totalMatches;
            this.Targets = targets;
        }
    }
}
