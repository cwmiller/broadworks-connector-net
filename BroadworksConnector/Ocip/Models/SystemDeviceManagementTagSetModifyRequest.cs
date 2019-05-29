using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagSetModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "tagSetName", IsNullable = false)]
    public string TagSetName { get; set; }
    [XmlElement(ElementName = "newTagSetName", IsNullable = false)]
    public string NewTagSetName { get; set; }
 }
}
