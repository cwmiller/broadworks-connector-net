using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderIntegratedIMPGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useSystemServiceDomain", IsNullable = false)]
    public bool UseSystemServiceDomain { get; set; }
    [XmlElement(ElementName = "serviceDomain", IsNullable = false)]
    public string ServiceDomain { get; set; }
 }
}
