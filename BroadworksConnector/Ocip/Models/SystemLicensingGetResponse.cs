using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLicensingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "licenseStrictness", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LicenseStrictness LicenseStrictness { get; set; }
    [XmlElement(ElementName = "groupUserlimit", IsNullable = false)]
    public int GroupUserlimit { get; set; }
    [XmlElement(ElementName = "expirationDate", IsNullable = false)]
    public string ExpirationDate { get; set; }
    [XmlElement(ElementName = "hostId", IsNullable = false)]
    public List<string> HostId { get; set; }
    [XmlElement(ElementName = "licenseName", IsNullable = false)]
    public List<string> LicenseName { get; set; }
    [XmlElement(ElementName = "licenseTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable LicenseTable { get; set; }
 }
}
