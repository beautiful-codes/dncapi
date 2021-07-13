using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnc.api.Policies
{
    public class MainPolicyRequirement : IAuthorizationRequirement
    {
        public string[] groups = { "group1", "group2" };
    }
}
