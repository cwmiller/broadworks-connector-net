using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementTagModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "systemDefaultTagSet", IsNullable = false)]
    public bool SystemDefaultTagSet { get; set; }
    [XmlElement(ElementName = "tagSetName", IsNullable = false)]
    public string TagSetName { get; set; }
    [XmlElement(ElementName = "tagName", IsNullable = false)]
    public string TagName { get; set; }
    [XmlElement(ElementName = "tagValue", IsNullable = true)]
    public string TagValue { get; set; }
    [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = true)]
    public string TagValueToEncrypt { get; set; }
    [XmlElement(ElementName = "isTagValueOverridable", IsNullable = false)]
    public bool IsTagValueOverridable { get; set; }
 }
}
