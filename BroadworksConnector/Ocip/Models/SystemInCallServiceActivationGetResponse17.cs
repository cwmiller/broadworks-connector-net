using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInCallServiceActivationGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "defaultFlashActivationDigits", IsNullable = false)]
    public string DefaultFlashActivationDigits { get; set; }
    [XmlElement(ElementName = "defaultCallTransferActivationDigits", IsNullable = false)]
    public string DefaultCallTransferActivationDigits { get; set; }
 }
}
