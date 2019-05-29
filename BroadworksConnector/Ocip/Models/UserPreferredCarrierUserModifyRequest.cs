using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPreferredCarrierUserModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify IntraLataCarrier { get; set; }
    [XmlElement(ElementName = "interLataCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify InterLataCarrier { get; set; }
    [XmlElement(ElementName = "internationalCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierNameModify InternationalCarrier { get; set; }
 }
}
