using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderInCallServiceActivationGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "flashActivationDigits", IsNullable = false)]
    public string FlashActivationDigits { get; set; }
    [XmlElement(ElementName = "callTransferActivationDigits", IsNullable = false)]
    public string CallTransferActivationDigits { get; set; }
 }
}
