using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdminGetResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = false)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = false)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
    [XmlElement(ElementName = "administratorType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminType AdministratorType { get; set; }
    [XmlElement(ElementName = "locale", IsNullable = false)]
    public string Locale { get; set; }
    [XmlElement(ElementName = "encoding", IsNullable = false)]
    public string Encoding { get; set; }
 }
}
