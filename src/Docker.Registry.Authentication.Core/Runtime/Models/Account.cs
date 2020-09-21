namespace Docker.Registry.Authentication.Configuration.Runtime.Models
{
    /// <summary>
    /// Represents an account in the authentication system.
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Gets or sets a unique name for this account.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the password hash for this account.
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// Gets or sets the tokens limitation issued for this account.
        /// </summary>
        /// <remarks>
        /// The values ​​in this limits override the global limits for this account. This property can be null.
        /// </remarks>
        public AuthenticationTokenLimitation TokenLimitation { get; set; }
    }
}
