using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemInCallServiceActivationModifyRequest17 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "defaultFlashActivationDigits", IsNullable = false)]
    public string DefaultFlashActivationDigits { get; set; }
    [XmlElement(ElementName = "defaultCallTransferActivationDigits", IsNullable = false)]
    public string DefaultCallTransferActivationDigits { get; set; }
 }
}
