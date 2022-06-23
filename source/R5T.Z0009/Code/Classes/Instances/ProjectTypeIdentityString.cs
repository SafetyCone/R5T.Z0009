using System;


namespace R5T.Z0009
{
	public class ProjectTypeIdentityString : IProjectTypeIdentityString
	{
		#region Infrastructure

	    public static ProjectTypeIdentityString Instance { get; } = new();

	    private ProjectTypeIdentityString()
	    {
        }

	    #endregion
	}
}