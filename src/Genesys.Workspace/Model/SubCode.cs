using System;
namespace Genesys.Workspace.Model
{
    public class SubCode
    {
        public string name { get; set; }
        public string code { get; set; }

        public override string ToString()
        {
            return string.Format("[SubCode: name={0}, code={1}]", name, code);
        }
    }
}
