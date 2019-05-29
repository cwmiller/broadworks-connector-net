using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserFlexibleSeatingGuestModifyRequest22 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "enableAssociationLimit", IsNullable = false)]
    public bool EnableAssociationLimit { get; set; }
    [XmlElement(ElementName = "associationLimitHours", IsNullable = false)]
    public int AssociationLimitHours { get; set; }
    [XmlElement(ElementName = "unlockPhonePINCode", IsNullable = true)]
    public string UnlockPhonePINCode { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointModify22 AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "hostUserId", IsNullable = true)]
    public string HostUserId { get; set; }
 }
}
