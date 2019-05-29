using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public string CountryCode { get; set; }
    [XmlElement(ElementName = "intraLataCarrier", IsNullable = false)]
    public string IntraLataCarrier { get; set; }
    [XmlElement(ElementName = "interLataCarrier", IsNullable = false)]
    public string InterLataCarrier { get; set; }
    [XmlElement(ElementName = "internationalCarrier", IsNullable = false)]
    public string InternationalCarrier { get; set; }
 }
}
