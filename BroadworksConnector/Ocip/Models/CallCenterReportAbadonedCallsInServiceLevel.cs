using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The call center enhanced reporting abadoned calls possible values for service level thresholds
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterReportAbadonedCallsInServiceLevel
    {
        [XmlEnum(Name = "Ignore All Abandoned Calls")]
        IgnoreAllAbandonedCalls,
        [XmlEnum(Name = "Include All Abandoned Calls")]
        IncludeAllAbandonedCalls,
        [XmlEnum(Name = "Include Abandoned Calls Except Before Entrance Completes")]
        IncludeAbandonedCallsExceptBeforeEntranceCompletes,
        [XmlEnum(Name = "Include Abandoned Calls Except In Interval")]
        IncludeAbandonedCallsExceptInInterval,
    }
}
