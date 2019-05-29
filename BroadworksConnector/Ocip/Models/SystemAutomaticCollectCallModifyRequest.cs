using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAutomaticCollectCallModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false)]
    public bool EnableAutomaticCollectCall { get; set; }
    [XmlElement(ElementName = "enableConnectTone", IsNullable = false)]
    public bool EnableConnectTone { get; set; }
 }
}
