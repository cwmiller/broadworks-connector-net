using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class StreetAddress 
{
    [XmlElement(ElementName = "addressLine1", IsNullable = true)]
    public string AddressLine1 { get; set; }
    [XmlElement(ElementName = "addressLine2", IsNullable = true)]
    public string AddressLine2 { get; set; }
    [XmlElement(ElementName = "city", IsNullable = true)]
    public string City { get; set; }
    [XmlElement(ElementName = "stateOrProvince", IsNullable = true)]
    public string StateOrProvince { get; set; }
    [XmlElement(ElementName = "stateOrProvinceDisplayName", IsNullable = false)]
    public string StateOrProvinceDisplayName { get; set; }
    [XmlElement(ElementName = "zipOrPostalCode", IsNullable = true)]
    public string ZipOrPostalCode { get; set; }
    [XmlElement(ElementName = "country", IsNullable = true)]
    public string Country { get; set; }
 }
}
