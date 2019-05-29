using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobileManagerGetHomeZoneResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "homeZoneDomainName", IsNullable = false)]
    public string HomeZoneDomainName { get; set; }
    [XmlElement(ElementName = "mobileCountryCode", IsNullable = false)]
    public string MobileCountryCode { get; set; }
    [XmlElement(ElementName = "mobileNetworkCode", IsNullable = false)]
    public string MobileNetworkCode { get; set; }
    [XmlElement(ElementName = "locationAreaCode", IsNullable = false)]
    public string LocationAreaCode { get; set; }
    [XmlElement(ElementName = "cellIdentity", IsNullable = false)]
    public string CellIdentity { get; set; }
 }
}
