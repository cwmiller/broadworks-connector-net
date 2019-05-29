using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallCenterReportAbadonedCallsInServiceLevel{
    IgnoreAllAbandonedCalls,
    IncludeAllAbandonedCalls,
    IncludeAbandonedCallsExceptBeforeEntranceCompletes,
    IncludeAbandonedCallsExceptInInterval,
 }
}
