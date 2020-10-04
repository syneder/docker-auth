namespace Docker.Registry.Authentication.DataLayer.Models
{
    /// <summary>
    /// Represents the token configuration in an authentication system.
    /// </summary>
    public class TokenConfigurationEntity
    {
        /// <summary>
        /// Gets or sets the account name associated with this configuration.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the token expiration time for this configuration.
        /// </summary>
        public uint? Expiration { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint or public key of the token-signing certificate
        /// associated with this configuration.
        /// </summary>
        public string SigningKey { get; set; }
    }
}
