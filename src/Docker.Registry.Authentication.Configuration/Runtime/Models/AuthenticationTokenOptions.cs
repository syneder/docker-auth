using System.Security.Cryptography.X509Certificates;

namespace Docker.Registry.Authentication.Configuration.Runtime.Models
{
    /// <summary>
    /// Represents parameters that can be used to configure the limits of issued tokens in the authentication system.
    /// </summary>
    public class AuthenticationTokenOptions : AuthenticationTokenLimitation
    {
        /// <summary>
        /// Gets or sets the name of the issuer on whose behalf tokens are issued.
        /// </summary>
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or sets the certificate for signing issued tokens.
        /// </summary>
        public X509Certificate2 Certificate { get; set; }
    }
}
