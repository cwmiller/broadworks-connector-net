using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPreferredCarrierGroupGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierName IntraLataCarrier { get; set; }
    [XmlElement(ElementName = "interLataCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierName InterLataCarrier { get; set; }
    [XmlElement(ElementName = "internationalCarrier", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupPreferredCarrierName InternationalCarrier { get; set; }
 }
}
