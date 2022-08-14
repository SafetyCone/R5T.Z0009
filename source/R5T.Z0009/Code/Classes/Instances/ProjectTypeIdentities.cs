using System;


namespace R5T.Z0009
{
	public class ProjectTypeIdentities : IProjectTypeIdentities
	{
		#region Infrastructure

	    public static ProjectTypeIdentities Instance { get; } = new();

	    private ProjectTypeIdentities()
	    {
        }

	    #endregion
	}
}