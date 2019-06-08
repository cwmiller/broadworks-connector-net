using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PublicClusterGetFullyQualifiedDomainNameResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _publicClusterFQDN;

    [XmlElement(ElementName = "publicClusterFQDN", IsNullable = false, Namespace = "")]
    public string PublicClusterFQDN {
        get => _publicClusterFQDN;
        set {
            PublicClusterFQDNSpecified = true;
            _publicClusterFQDN = value;
        }
    }

    [XmlIgnore]
    public bool PublicClusterFQDNSpecified { get; set; }
}
}
