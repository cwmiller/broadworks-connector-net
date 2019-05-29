using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierGetAvailableCountryCodeListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "defaultCountryCode", IsNullable = false)]
    public string DefaultCountryCode { get; set; }
    [XmlElement(ElementName = "countryCode", IsNullable = false)]
    public List<string> CountryCode { get; set; }
 }
}
