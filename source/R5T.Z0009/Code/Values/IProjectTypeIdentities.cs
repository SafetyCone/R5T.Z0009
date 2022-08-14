using System;

using R5T.T0131;


namespace R5T.Z0009
{
	[ValuesMarker]
	public partial interface IProjectTypeIdentities : IValuesMarker
	{
		private static F0000.IGuidOperator Operator { get; } = F0000.GuidOperator.Instance;
		private static IProjectTypeIdentityStrings Strings { get; } = ProjectTypeIdentityStrings.Instance;


		public Guid CSharpProject => Operator.Parse(Strings.CSharpProject);
		public Guid SolutionFolder => Operator.Parse(Strings.SolutionFolder);
	}
}