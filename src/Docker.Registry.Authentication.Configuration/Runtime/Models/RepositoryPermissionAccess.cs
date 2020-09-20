using System;

namespace Docker.Registry.Authentication.Configuration.Runtime.Models
{
    /// <summary>
    /// Specifies the type of repository access requested.
    /// </summary>
    [Flags]
    public enum RepositoryPermissionAccess
    {
        /// <summary>
        /// Access to push an image to the repository.
        /// </summary>
        Pull = 1,

        /// <summary>
        /// Access to pull images from the repository.
        /// </summary>
        Push = 2,

        /// <summary>
        /// Full access to the repository.
        /// </summary>
        Full = Pull | Push
    }
}
