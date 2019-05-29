using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PublicClusterGetFullyQualifiedDomainNameResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "publicClusterFQDN", IsNullable = false)]
    public string PublicClusterFQDN { get; set; }
 }
}
