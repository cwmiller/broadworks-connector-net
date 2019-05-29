using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallCenterReportSamplingPeriod{
    _15Minutes,
    _30Minutes,
    Hourly,
    Daily,
    Weekly,
    Monthly,
 }
}
