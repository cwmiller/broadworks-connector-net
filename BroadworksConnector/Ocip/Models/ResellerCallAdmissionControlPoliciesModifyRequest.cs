using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerCallAdmissionControlPoliciesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "enableCallAdmissionControl", IsNullable = false)]
    public bool EnableCallAdmissionControl { get; set; }
    [XmlElement(ElementName = "maxConcurrentNetworkSessions", IsNullable = false)]
    public int MaxConcurrentNetworkSessions { get; set; }
    [XmlElement(ElementName = "maxConcurrentNetworkSessionsThreshold", IsNullable = true)]
    public int? MaxConcurrentNetworkSessionsThreshold { get; set; }
    [XmlElement(ElementName = "maxNetworkCallsPerSecond", IsNullable = false)]
    public int MaxNetworkCallsPerSecond { get; set; }
    [XmlElement(ElementName = "maxNetworkCallsPerSecondThreshold", IsNullable = true)]
    public int? MaxNetworkCallsPerSecondThreshold { get; set; }
    [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessions", IsNullable = false)]
    public int MaxConcurrentExternalSIPRECSessions { get; set; }
    [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessionsThreshold", IsNullable = true)]
    public int? MaxConcurrentExternalSIPRECSessionsThreshold { get; set; }
 }
}
