using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false)]
    public bool SystemDefaultTagSet { get; set; }
    [XmlElement(ElementName = "tagSetName", IsNullable = false)]
    public string TagSetName { get; set; }
    [XmlElement(ElementName = "tagName", IsNullable = false)]
    public List<string> TagName { get; set; }
 }
}
