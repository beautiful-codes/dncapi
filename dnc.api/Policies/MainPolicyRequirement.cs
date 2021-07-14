using Microsoft.AspNetCore.Authorization;

namespace dnc.api.Policies
{
    public class MainPolicyRequirement : IAuthorizationRequirement
    {
        public string[] groups = { "group1", "group2" };
    }
}
