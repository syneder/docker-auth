namespace Docker.Registry.Authentication.Configuration.Runtime.Models
{
    /// <summary>
    /// Represents the limits of issued tokens in the authentication system.
    /// </summary>
    public class AuthenticationTokenLimitation
    {
        /// <summary>
        /// Gets or sets the validity period of the issued tokens in seconds.
        /// </summary>
        public uint? Expiration { get; set; }
    }
}
