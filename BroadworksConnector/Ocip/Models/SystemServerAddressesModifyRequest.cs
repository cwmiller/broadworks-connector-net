using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServerAddressesModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "webServerClusterPublicFQDN", IsNullable = true)]
    public string WebServerClusterPublicFQDN { get; set; }
    [XmlElement(ElementName = "applicationServerClusterPrimaryPublicFQDN", IsNullable = true)]
    public string ApplicationServerClusterPrimaryPublicFQDN { get; set; }
    [XmlElement(ElementName = "applicationServerClusterSecondaryPublicFQDN", IsNullable = true)]
    public string ApplicationServerClusterSecondaryPublicFQDN { get; set; }
    [XmlElement(ElementName = "applicationServerClusterPrimaryPrivateFQDN", IsNullable = true)]
    public string ApplicationServerClusterPrimaryPrivateFQDN { get; set; }
    [XmlElement(ElementName = "applicationServerClusterSecondaryPrivateFQDN", IsNullable = true)]
    public string ApplicationServerClusterSecondaryPrivateFQDN { get; set; }
 }
}
