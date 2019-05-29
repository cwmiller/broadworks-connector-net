using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupExtensionLengthModifyRequest17 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "minExtensionLength", IsNullable = false)]
    public int MinExtensionLength { get; set; }
    [XmlElement(ElementName = "maxExtensionLength", IsNullable = false)]
    public int MaxExtensionLength { get; set; }
    [XmlElement(ElementName = "defaultExtensionLength", IsNullable = false)]
    public int DefaultExtensionLength { get; set; }
 }
}
