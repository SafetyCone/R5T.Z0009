using System;

using R5T.F0000;


namespace R5T.Z0009
{
    public static class Instances
    {
        public static IGuidOperator GuidOperator { get; } = F0000.GuidOperator.Instance;
        public static IProjectTypeIdentityStrings ProjectTypeIdentityStrings { get; } = Z0009.ProjectTypeIdentityStrings.Instance;
    }
}