using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserRouteListGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "treatOriginationsAndPBXRedirectionsAsScreened", IsNullable = false)]
    public bool TreatOriginationsAndPBXRedirectionsAsScreened { get; set; }
    [XmlElement(ElementName = "useRouteListIdentityForNonEmergencyCalls", IsNullable = false)]
    public bool UseRouteListIdentityForNonEmergencyCalls { get; set; }
    [XmlElement(ElementName = "useRouteListIdentityForEmergencyCalls", IsNullable = false)]
    public bool UseRouteListIdentityForEmergencyCalls { get; set; }
    [XmlElement(ElementName = "assignedNumberRangeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AssignedNumberRangeTable { get; set; }
    [XmlElement(ElementName = "assignedNumberPrefixTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AssignedNumberPrefixTable { get; set; }
 }
}
