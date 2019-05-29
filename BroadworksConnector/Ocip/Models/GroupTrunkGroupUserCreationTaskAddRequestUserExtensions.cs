using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupUserCreationTaskAddRequestUserExtensions 
{
    [XmlElement(ElementName = "extension", IsNullable = false)]
    public List<string> Extension { get; set; }
    [XmlElement(ElementName = "extensionRange", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.ExtensionRange> ExtensionRange { get; set; }
 }
}
