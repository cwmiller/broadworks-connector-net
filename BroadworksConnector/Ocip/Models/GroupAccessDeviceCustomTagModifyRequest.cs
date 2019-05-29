using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceCustomTagModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "deviceName", IsNullable = false)]
    public string DeviceName { get; set; }
    [XmlElement(ElementName = "tagName", IsNullable = false)]
    public string TagName { get; set; }
    [XmlElement(ElementName = "tagValue", IsNullable = true)]
    public string TagValue { get; set; }
    [XmlElement(ElementName = "tagValueToEncrypt", IsNullable = true)]
    public string TagValueToEncrypt { get; set; }
 }
}
