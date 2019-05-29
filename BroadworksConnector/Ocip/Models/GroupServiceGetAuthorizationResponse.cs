using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupServiceGetAuthorizationResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "authorized", IsNullable = false)]
    public bool Authorized { get; set; }
    [XmlElement(ElementName = "authorizedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt AuthorizedQuantity { get; set; }
    [XmlElement(ElementName = "usedQuantity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UnboundedNonNegativeInt UsedQuantity { get; set; }
    [XmlElement(ElementName = "authorizable", IsNullable = false)]
    public bool Authorizable { get; set; }
 }
}
