using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierGetCarrierListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false)]
    public List<string> IntraLataCarrier { get; set; }
    [XmlElement(ElementName = "interLataCarrier", IsNullable = false)]
    public List<string> InterLataCarrier { get; set; }
    [XmlElement(ElementName = "internationalCarrier", IsNullable = false)]
    public List<string> InternationalCarrier { get; set; }
 }
}
