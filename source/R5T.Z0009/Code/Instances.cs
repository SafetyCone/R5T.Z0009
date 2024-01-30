using System;


namespace R5T.Z0009
{
    public static class Instances
    {
        public static L0066.IGuidOperator GuidOperator { get; } = L0066.GuidOperator.Instance;
        public static IProjectTypeIdentityStrings ProjectTypeIdentityStrings { get; } = Z0009.ProjectTypeIdentityStrings.Instance;
    }
}