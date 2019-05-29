using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCountryCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "defaultCountryCode", IsNullable = false)]
    public string DefaultCountryCode { get; set; }
    [XmlElement(ElementName = "countryCodeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable CountryCodeTable { get; set; }
 }
}
