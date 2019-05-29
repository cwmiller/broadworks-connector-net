using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallCenterReportIntervalTimeUnit{
    Hour,
    Day,
    Week,
    Month,
    Year,
 }
}
