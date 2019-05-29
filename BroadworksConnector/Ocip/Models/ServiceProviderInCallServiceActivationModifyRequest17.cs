using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderInCallServiceActivationModifyRequest17 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "flashActivationDigits", IsNullable = false)]
    public string FlashActivationDigits { get; set; }
    [XmlElement(ElementName = "callTransferActivationDigits", IsNullable = false)]
    public string CallTransferActivationDigits { get; set; }
 }
}
