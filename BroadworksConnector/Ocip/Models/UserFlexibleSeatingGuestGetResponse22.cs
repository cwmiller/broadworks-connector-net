using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserFlexibleSeatingGuestGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "enableAssociationLimit", IsNullable = false)]
    public bool EnableAssociationLimit { get; set; }
    [XmlElement(ElementName = "associationLimitHours", IsNullable = false)]
    public int AssociationLimitHours { get; set; }
    [XmlElement(ElementName = "unlockPhonePINCode", IsNullable = false)]
    public string UnlockPhonePINCode { get; set; }
    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceMultipleContactEndpointRead22 AccessDeviceEndpoint { get; set; }
    [XmlElement(ElementName = "hostUserId", IsNullable = false)]
    public string HostUserId { get; set; }
    [XmlElement(ElementName = "hostLastName", IsNullable = false)]
    public string HostLastName { get; set; }
    [XmlElement(ElementName = "hostFirstName", IsNullable = false)]
    public string HostFirstName { get; set; }
    [XmlElement(ElementName = "hostAssociationDateTime", IsNullable = false)]
    public string HostAssociationDateTime { get; set; }
    [XmlElement(ElementName = "hostEnforcesAssociationLimit", IsNullable = false)]
    public bool HostEnforcesAssociationLimit { get; set; }
    [XmlElement(ElementName = "hostAssociationLimitHours", IsNullable = false)]
    public int HostAssociationLimitHours { get; set; }
 }
}
