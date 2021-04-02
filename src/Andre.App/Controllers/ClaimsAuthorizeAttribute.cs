using System;

namespace Andre.App.Controllers
{
    internal class ClaimsAuthorizeAttribute : Attribute
    {
        public ClaimsAuthorizeAttribute(string v1, string v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public string V1 { get; }
        public string V2 { get; }
    }
}