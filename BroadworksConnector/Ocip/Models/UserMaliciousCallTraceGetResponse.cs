using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMaliciousCallTraceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "traceTypeSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection TraceTypeSelection { get; set; }
    [XmlElement(ElementName = "traceForTimePeriod", IsNullable = false)]
    public bool TraceForTimePeriod { get; set; }
    [XmlElement(ElementName = "traceTimePeriod", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MaliciousCallTraceTimePeriod TraceTimePeriod { get; set; }
 }
}
