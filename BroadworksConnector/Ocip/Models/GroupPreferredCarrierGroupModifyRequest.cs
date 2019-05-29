using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPreferredCarrierGroupModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierNameModify IntraLataCarrier { get; set; }
    [XmlElement(ElementName = "interLataCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierNameModify InterLataCarrier { get; set; }
    [XmlElement(ElementName = "internationalCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierNameModify InternationalCarrier { get; set; }
 }
}
