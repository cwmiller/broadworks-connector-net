using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointGetFailoverPolicyResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableFailoverSupport", IsNullable = false)]
    public bool EnableFailoverSupport { get; set; }
    [XmlElement(ElementName = "externalSystem", IsNullable = false)]
    public string ExternalSystem { get; set; }
    [XmlElement(ElementName = "failoverPhoneNumber", IsNullable = false)]
    public string FailoverPhoneNumber { get; set; }
    [XmlElement(ElementName = "failoverStatus", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RoutePointFailoverStatus FailoverStatus { get; set; }
    [XmlElement(ElementName = "perCallEnableFailoverSupport", IsNullable = false)]
    public bool PerCallEnableFailoverSupport { get; set; }
    [XmlElement(ElementName = "perCallCallFailureTimeoutSeconds", IsNullable = false)]
    public int PerCallCallFailureTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "perCallOutboundCallFailureTimeoutSeconds", IsNullable = false)]
    public int PerCallOutboundCallFailureTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "perCallFailoverPhoneNumber", IsNullable = false)]
    public string PerCallFailoverPhoneNumber { get; set; }
 }
}
