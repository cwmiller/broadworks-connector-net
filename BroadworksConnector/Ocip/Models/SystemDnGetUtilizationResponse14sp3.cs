using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDnGetUtilizationResponse14sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "userType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserType UserType { get; set; }
    [XmlElement(ElementName = "isGroupCallingLineId", IsNullable = false)]
    public bool IsGroupCallingLineId { get; set; }
    [XmlElement(ElementName = "isActivated", IsNullable = false)]
    public bool IsActivated { get; set; }
 }
}
