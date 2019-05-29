using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "intraLataCarrier", IsNullable = true)]
    public string IntraLataCarrier { get; set; }
    [XmlElement(ElementName = "interLataCarrier", IsNullable = true)]
    public string InterLataCarrier { get; set; }
    [XmlElement(ElementName = "internationalCarrier", IsNullable = true)]
    public string InternationalCarrier { get; set; }
 }
}
