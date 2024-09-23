using System;

using R5T.T0131;
using R5T.T0143;


namespace R5T.Z0009
{
	[ValuesMarker]
	public partial interface IProjectTypeIdentities : IValuesMarker
	{
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        private static IProjectTypeIdentityStrings _Strings { get; } = ProjectTypeIdentityStrings.Instance;

#pragma warning restore IDE1006 // Naming Styles


		/// <inheritdoc cref="IProjectTypeIdentityStrings.CSharpProject"/>
        public Guid CSharpProject => Instances.GuidOperator.Parse(_Strings.CSharpProject);

        /// <inheritdoc cref="IProjectTypeIdentityStrings.SolutionFolder"/>
        public Guid SolutionFolder => Instances.GuidOperator.Parse(_Strings.SolutionFolder);
	}
}