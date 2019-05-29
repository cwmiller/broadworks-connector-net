using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServerAddressesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "webServerClusterPublicFQDN", IsNullable = false)]
    public string WebServerClusterPublicFQDN { get; set; }
    [XmlElement(ElementName = "applicationServerClusterPrimaryPublicFQDN", IsNullable = false)]
    public string ApplicationServerClusterPrimaryPublicFQDN { get; set; }
    [XmlElement(ElementName = "applicationServerClusterSecondaryPublicFQDN", IsNullable = false)]
    public string ApplicationServerClusterSecondaryPublicFQDN { get; set; }
    [XmlElement(ElementName = "applicationServerClusterPrimaryPrivateFQDN", IsNullable = false)]
    public string ApplicationServerClusterPrimaryPrivateFQDN { get; set; }
    [XmlElement(ElementName = "applicationServerClusterSecondaryPrivateFQDN", IsNullable = false)]
    public string ApplicationServerClusterSecondaryPrivateFQDN { get; set; }
 }
}
