using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;

namespace dnc.api.Policies
{
    public class MainPolicyHandler : AuthorizationHandler<MainPolicyRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MainPolicyRequirement requirement)
        {
            if (context.User.Claims
                    .Where(c => c.Type == "Groups")
                    .Any(groupClaim => requirement.groups.Contains(groupClaim.Value)))
                context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
