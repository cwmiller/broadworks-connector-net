using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFlexibleSeatingHostGuestAssociationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "enforceAssociationLimit", IsNullable = false)]
    public bool EnforceAssociationLimit { get; set; }
    [XmlElement(ElementName = "associationLimitHours", IsNullable = false)]
    public int AssociationLimitHours { get; set; }
    [XmlElement(ElementName = "accessLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.FlexibleSeatingHostAccessLevel AccessLevel { get; set; }
    [XmlElement(ElementName = "removeGuestAssociation", IsNullable = false)]
    public bool RemoveGuestAssociation { get; set; }
 }
}
