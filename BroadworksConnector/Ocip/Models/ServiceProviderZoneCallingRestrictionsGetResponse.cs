using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderZoneCallingRestrictionsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableZoneCallingRestrictions", IsNullable = false)]
    public bool EnableZoneCallingRestrictions { get; set; }
    [XmlElement(ElementName = "enableOriginationRoamingRestrictions", IsNullable = false)]
    public bool EnableOriginationRoamingRestrictions { get; set; }
    [XmlElement(ElementName = "enableEmergencyOriginationRoamingRestrictions", IsNullable = false)]
    public bool EnableEmergencyOriginationRoamingRestrictions { get; set; }
    [XmlElement(ElementName = "enableTerminationRoamingRestrictions", IsNullable = false)]
    public bool EnableTerminationRoamingRestrictions { get; set; }
 }
}
