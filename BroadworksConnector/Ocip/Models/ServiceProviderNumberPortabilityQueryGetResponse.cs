using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderNumberPortabilityQueryGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableNumberPortabilityQueryForOutgoingCalls", IsNullable = false)]
    public bool EnableNumberPortabilityQueryForOutgoingCalls { get; set; }
    [XmlElement(ElementName = "enableNumberPortabilityQueryForIncomingCalls", IsNullable = false)]
    public bool EnableNumberPortabilityQueryForIncomingCalls { get; set; }
    [XmlElement(ElementName = "enableNumberPortabilityQueryForNetworkCallsOnly", IsNullable = false)]
    public bool EnableNumberPortabilityQueryForNetworkCallsOnly { get; set; }
    [XmlElement(ElementName = "digitPattern", IsNullable = false)]
    public List<string> DigitPattern { get; set; }
 }
}
