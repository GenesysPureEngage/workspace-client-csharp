using System;
using System.Collections.Generic;
using Genesys.Workspace.Common;
using Genesys.Workspace.Model;

namespace Genesys.Workspace.Model
{
    public class ActionCode
    {
        public string name { get; set; }
        public string code { get; set; }
        public ActionCodeType type { get; set; }
        public List<SubCode> subCodes { get; set; }
        public KeyValueCollection userProperties { get; set; }

        public ActionCode() { }

        public override string ToString()
        {
            return string.Format("[ActionCode: name={0}, code={1}, type={2}, subCodes={3}, userProperties={4}]", name, code, type, subCodes, userProperties);
        }
    }
}
