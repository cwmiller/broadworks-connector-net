using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupExtensionLengthGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "minExtensionLength", IsNullable = false)]
    public int MinExtensionLength { get; set; }
    [XmlElement(ElementName = "maxExtensionLength", IsNullable = false)]
    public int MaxExtensionLength { get; set; }
    [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false)]
    public int DefaultExtensionLength { get; set; }
 }
}
