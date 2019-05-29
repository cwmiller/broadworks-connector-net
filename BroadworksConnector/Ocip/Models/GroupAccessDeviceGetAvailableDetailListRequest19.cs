using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAccessDeviceGetAvailableDetailListRequest19 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "isMusicOnHold", IsNullable = false)]
    public bool IsMusicOnHold { get; set; }
    [XmlElement(ElementName = "onlyVideoCapable", IsNullable = false)]
    public bool OnlyVideoCapable { get; set; }
 }
}
