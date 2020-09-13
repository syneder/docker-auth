using Docker.Registry.Authentication.Web.Internal;
using Microsoft.AspNetCore.Authentication;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class BasicAuthenticationExtensions
    {
        public static AuthenticationBuilder AddBasic(this AuthenticationBuilder builder)
            => builder.AddBasic(BasicAuthenticationDefaults.AuthenticationScheme, _ => { });

        public static AuthenticationBuilder AddBasic(this AuthenticationBuilder builder,
            Action<AuthenticationSchemeOptions> configureOptions)
        {
            return builder.AddBasic(BasicAuthenticationDefaults.AuthenticationScheme, configureOptions);
        }

        public static AuthenticationBuilder AddBasic(this AuthenticationBuilder builder, string authenticationScheme,
            Action<AuthenticationSchemeOptions> configureOptions)
        {
            return builder.AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>(
                authenticationScheme, null, configureOptions);
        }
    }
}
