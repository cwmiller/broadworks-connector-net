using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false)]
    public string IntraLataCarrier { get; set; }
    [XmlElement(ElementName = "interLataCarrier", IsNullable = false)]
    public string InterLataCarrier { get; set; }
    [XmlElement(ElementName = "internationalCarrier", IsNullable = false)]
    public string InternationalCarrier { get; set; }
 }
}
