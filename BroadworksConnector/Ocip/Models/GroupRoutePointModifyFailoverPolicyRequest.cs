using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointModifyFailoverPolicyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "enableFailoverSupport", IsNullable = false)]
    public bool EnableFailoverSupport { get; set; }
    [XmlElement(ElementName = "externalSystem", IsNullable = true)]
    public string ExternalSystem { get; set; }
    [XmlElement(ElementName = "failoverPhoneNumber", IsNullable = true)]
    public string FailoverPhoneNumber { get; set; }
    [XmlElement(ElementName = "perCallEnableFailoverSupport", IsNullable = false)]
    public bool PerCallEnableFailoverSupport { get; set; }
    [XmlElement(ElementName = "perCallCallFailureTimeoutSeconds", IsNullable = false)]
    public int PerCallCallFailureTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "perCallOutboundCallFailureTimeoutSeconds", IsNullable = false)]
    public int PerCallOutboundCallFailureTimeoutSeconds { get; set; }
    [XmlElement(ElementName = "perCallFailoverPhoneNumber", IsNullable = true)]
    public string PerCallFailoverPhoneNumber { get; set; }
 }
}
