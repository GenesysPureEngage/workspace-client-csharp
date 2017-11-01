using System;
using Genesys.Workspace.Common;

namespace Genesys.Workspace.Model
{
    public class TargetsSearchOptions
    {
        public string FilterName { get; set; }
        public TargetType[] Types { get; set; }
        public bool Desc { get; set; }
        public int? Limit { get; set; }
        public bool Exact { get; set; }
    }
}
