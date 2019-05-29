using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPreferredCarrierUserGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierName IntraLataCarrier { get; set; }
    [XmlElement(ElementName = "interLataCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierName InterLataCarrier { get; set; }
    [XmlElement(ElementName = "internationalCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserPreferredCarrierName InternationalCarrier { get; set; }
 }
}
