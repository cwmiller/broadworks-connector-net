using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDirectedCallPickupWithBargeInModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "enableBargeInWarningTone", IsNullable = false)]
    public bool EnableBargeInWarningTone { get; set; }
    [XmlElement(ElementName = "enableAutomaticTargetSelection", IsNullable = false)]
    public bool EnableAutomaticTargetSelection { get; set; }
 }
}
