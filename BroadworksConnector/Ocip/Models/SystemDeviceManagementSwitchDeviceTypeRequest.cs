using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementSwitchDeviceTypeRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "svcProviderId", IsNullable = false)]
    public string SvcProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "fromDeviceType", IsNullable = false)]
    public string FromDeviceType { get; set; }
    [XmlElement(ElementName = "toDeviceType", IsNullable = false)]
    public string ToDeviceType { get; set; }
 }
}
