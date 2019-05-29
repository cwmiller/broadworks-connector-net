using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PrimaryInfoGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isPrimary", IsNullable = false)]
    public bool IsPrimary { get; set; }
    [XmlElement(ElementName = "hostnameForPrimary", IsNullable = false)]
    public string HostnameForPrimary { get; set; }
    [XmlElement(ElementName = "addressForPrimary", IsNullable = false)]
    public List<string> AddressForPrimary { get; set; }
    [XmlElement(ElementName = "privateAddressForPrimary", IsNullable = false)]
    public List<string> PrivateAddressForPrimary { get; set; }
 }
}
