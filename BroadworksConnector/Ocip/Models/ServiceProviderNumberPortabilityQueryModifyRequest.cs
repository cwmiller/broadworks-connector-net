using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderNumberPortabilityQueryModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "enableNumberPortabilityQueryForOutgoingCalls", IsNullable = false)]
    public bool EnableNumberPortabilityQueryForOutgoingCalls { get; set; }
    [XmlElement(ElementName = "enableNumberPortabilityQueryForIncomingCalls", IsNullable = false)]
    public bool EnableNumberPortabilityQueryForIncomingCalls { get; set; }
    [XmlElement(ElementName = "enableNumberPortabilityQueryForNetworkCallsOnly", IsNullable = false)]
    public bool EnableNumberPortabilityQueryForNetworkCallsOnly { get; set; }
    [XmlElement(ElementName = "deleteDigitPattern", IsNullable = false)]
    public List<string> DeleteDigitPattern { get; set; }
 }
}
