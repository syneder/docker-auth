using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;
using System;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    internal class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock) : base(options, logger, encoder, clock) { }

        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            string authorizationHeader = Request.Headers[HeaderNames.Authorization];
            if (string.IsNullOrEmpty(authorizationHeader))
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            var authorizationCredentials = authorizationHeader.Trim();
            if (authorizationHeader.StartsWith("Basic ", StringComparison.OrdinalIgnoreCase))
            {
                authorizationCredentials = authorizationCredentials.Substring("Basic ".Length).TrimStart();
            }

            if (string.IsNullOrEmpty(authorizationCredentials))
            {
                return Task.FromResult(AuthenticateResult.NoResult());
            }

            var encodedCredentials = Convert.FromBase64String(authorizationCredentials);
            var credentials = Encoding.ASCII.GetString(encodedCredentials);
            var username = credentials.Split(new[] { ':' }, count: 2)[0];

            var identity = new ClaimsIdentity(ClaimsIssuer);
            identity.AddClaim(new Claim(ClaimTypes.Name, username));
            var principal = new ClaimsPrincipal(identity);

            var authenticationTicket = new AuthenticationTicket(principal, Scheme.Name);
            return Task.FromResult(AuthenticateResult.Success(authenticationTicket));
        }
    }
}
