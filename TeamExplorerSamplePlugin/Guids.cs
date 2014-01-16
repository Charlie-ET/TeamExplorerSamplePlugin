// Guids.cs
// MUST match guids.h
using System;

namespace Company.TeamExplorerSamplePlugin
{
    static class GuidList
    {
        public const string guidTeamExplorerSamplePluginPkgString = "86d2a387-cc09-456b-93be-08654274a594";
        public const string guidTeamExplorerSamplePluginCmdSetString = "82f90f74-bb49-4fd6-b372-6ce70eae6508";

        public static readonly Guid guidTeamExplorerSamplePluginCmdSet = new Guid(guidTeamExplorerSamplePluginCmdSetString);

        public const string sampleTeamExplorerNavigationItem = "8C35B3DF-D7CC-45BC-B958-BFAE3E157A21";

        public const string sampleTeamExplorerPage = "8C4F4A24-38C3-451C-A55F-9532EA61E841";

        public const string sampleTeamExplorerSection = "09C3A4DF-7040-4AC4-BA8B-0740B53BD9D7";

    };
}