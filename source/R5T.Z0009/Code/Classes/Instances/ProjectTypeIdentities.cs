using System;


namespace R5T.Z0009
{
	public class ProjectTypeIdentities : IProjectTypeIdentities
	{
		#region Infrastructure

	    public static IProjectTypeIdentities Instance { get; } = new ProjectTypeIdentities();

	    private ProjectTypeIdentities()
	    {
        }

	    #endregion
	}
}