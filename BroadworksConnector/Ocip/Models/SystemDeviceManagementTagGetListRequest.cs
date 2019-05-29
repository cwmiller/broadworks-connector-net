using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false)]
    public bool SystemDefaultTagSet { get; set; }
    [XmlElement(ElementName = "tagSetName", IsNullable = false)]
    public string TagSetName { get; set; }
 }
}
