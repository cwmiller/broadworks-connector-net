using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRouteListModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "treatOriginationsAndPBXRedirectionsAsScreened", IsNullable = false)]
    public bool TreatOriginationsAndPBXRedirectionsAsScreened { get; set; }
    [XmlElement(ElementName = "useRouteListIdentityForNonEmergencyCalls", IsNullable = false)]
    public bool UseRouteListIdentityForNonEmergencyCalls { get; set; }
    [XmlElement(ElementName = "useRouteListIdentityForEmergencyCalls", IsNullable = false)]
    public bool UseRouteListIdentityForEmergencyCalls { get; set; }
    [XmlElement(ElementName = "assignedNumberRangeStartList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementDNList AssignedNumberRangeStartList { get; set; }
    [XmlElement(ElementName = "assignedNumberPrefixList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.EnterpriseTrunkReplacementNumberPrefixList AssignedNumberPrefixList { get; set; }
 }
}
