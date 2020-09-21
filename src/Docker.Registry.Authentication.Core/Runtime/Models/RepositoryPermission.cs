namespace Docker.Registry.Authentication.Configuration.Runtime.Models
{
    /// <summary>
    /// Represents the repository permission for the specified account in the authentication system.
    /// </summary>
    public class RepositoryPermission
    {
        /// <summary>
        /// Gets or sets the name of the account that is granted access to the repository.
        /// </summary>
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or sets the name of the repository to which access is granted.
        /// </summary>
        public string Repository { get; set; }

        /// <summary>
        /// Gets or sets the access level of the specified account to the specified repository.
        /// </summary>
        public RepositoryPermissionAccess Access { get; set; }
    }
}
