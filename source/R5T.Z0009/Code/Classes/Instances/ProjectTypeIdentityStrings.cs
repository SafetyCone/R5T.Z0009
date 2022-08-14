using System;


namespace R5T.Z0009
{
	public class ProjectTypeIdentityStrings : IProjectTypeIdentityStrings
	{
		#region Infrastructure

	    public static ProjectTypeIdentityStrings Instance { get; } = new();

	    private ProjectTypeIdentityStrings()
	    {
        }

	    #endregion
	}
}