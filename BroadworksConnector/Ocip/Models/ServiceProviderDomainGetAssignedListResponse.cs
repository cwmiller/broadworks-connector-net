using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDomainGetAssignedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceProviderDefaultDomain", IsNullable = false)]
    public string ServiceProviderDefaultDomain { get; set; }
    [XmlElement(ElementName = "domain", IsNullable = false)]
    public List<string> Domain { get; set; }
 }
}
