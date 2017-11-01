using System;

namespace Genesys.Workspace.Common
{
    public class WorkspaceApiException : Exception
    {
        public WorkspaceApiException(String msg) : base(msg)
        {
        }

        public WorkspaceApiException(String msg, Exception cause) : base(msg, cause)
        {
        }
    }
}
