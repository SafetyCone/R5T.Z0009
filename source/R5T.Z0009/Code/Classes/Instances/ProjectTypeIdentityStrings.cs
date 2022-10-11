using System;


namespace R5T.Z0009
{
	public class ProjectTypeIdentityStrings : IProjectTypeIdentityStrings
	{
		#region Infrastructure

	    public static IProjectTypeIdentityStrings Instance { get; } = new ProjectTypeIdentityStrings();

	    private ProjectTypeIdentityStrings()
	    {
        }

	    #endregion
	}
}