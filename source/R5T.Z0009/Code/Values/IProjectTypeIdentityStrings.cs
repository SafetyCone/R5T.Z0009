using System;

using R5T.T0131;


namespace R5T.Z0009
{
	/// <summary>
	/// Values from:
	/// * https://www.codeproject.com/Reference/720512/List-of-Visual-Studio-Project-Type-GUIDs
	/// * https://cakebuild.net/api/Cake.Incubator.Project/ProjectTypes/
	/// </summary>
	[ValuesMarker]
	public partial interface IProjectTypeIdentityStrings : IValuesMarker
	{
        /// <summary>
        /// <para><value>9A19103F-16F7-4668-BE54-9A1E7A4F7556</value></para>
        /// </summary>
        public string CSharpProject => "9A19103F-16F7-4668-BE54-9A1E7A4F7556";

        /// <summary>
        /// <para><value>2150E333-8FDC-42A3-9474-1A3956D46DE8</value></para>
        /// </summary>
        public string SolutionFolder => "2150E333-8FDC-42A3-9474-1A3956D46DE8";
	}
}