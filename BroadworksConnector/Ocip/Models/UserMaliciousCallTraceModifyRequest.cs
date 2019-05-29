using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMaliciousCallTraceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "traceTypeSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MaliciousCallTraceCallTypeSelection TraceTypeSelection { get; set; }
    [XmlElement(ElementName = "traceForTimePeriod", IsNullable = false)]
    public bool TraceForTimePeriod { get; set; }
    [XmlElement(ElementName = "traceTimePeriod", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.MaliciousCallTraceTimePeriod TraceTimePeriod { get; set; }
 }
}
