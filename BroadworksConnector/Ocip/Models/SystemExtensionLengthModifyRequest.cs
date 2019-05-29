using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExtensionLengthModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "minExtensionLength", IsNullable = false)]
    public int MinExtensionLength { get; set; }
    [XmlElement(ElementName = "maxExtensionLength", IsNullable = false)]
    public int MaxExtensionLength { get; set; }
 }
}
