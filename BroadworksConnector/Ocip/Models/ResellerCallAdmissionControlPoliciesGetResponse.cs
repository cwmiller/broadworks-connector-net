using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerCallAdmissionControlPoliciesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableCallAdmissionControl", IsNullable = false)]
    public bool EnableCallAdmissionControl { get; set; }
    [XmlElement(ElementName = "maxConcurrentNetworkSessions", IsNullable = false)]
    public int MaxConcurrentNetworkSessions { get; set; }
    [XmlElement(ElementName = "maxConcurrentNetworkSessionsThreshold", IsNullable = false)]
    public int MaxConcurrentNetworkSessionsThreshold { get; set; }
    [XmlElement(ElementName = "maxNetworkCallsPerSecond", IsNullable = false)]
    public int MaxNetworkCallsPerSecond { get; set; }
    [XmlElement(ElementName = "maxNetworkCallsPerSecondThreshold", IsNullable = false)]
    public int MaxNetworkCallsPerSecondThreshold { get; set; }
    [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessions", IsNullable = false)]
    public int MaxConcurrentExternalSIPRECSessions { get; set; }
    [XmlElement(ElementName = "maxConcurrentExternalSIPRECSessionsThreshold", IsNullable = false)]
    public int MaxConcurrentExternalSIPRECSessionsThreshold { get; set; }
 }
}
