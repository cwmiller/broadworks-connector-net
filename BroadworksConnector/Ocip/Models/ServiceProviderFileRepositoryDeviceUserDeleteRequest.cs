using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderFileRepositoryDeviceUserDeleteRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "fileRepositoryName", IsNullable = false)]
    public string FileRepositoryName { get; set; }
    [XmlElement(ElementName = "userName", IsNullable = false)]
    public string UserName { get; set; }
 }
}
