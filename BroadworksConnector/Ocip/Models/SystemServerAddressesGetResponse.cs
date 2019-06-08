using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServerAddressesGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _webServerClusterPublicFQDN;

    [XmlElement(ElementName = "webServerClusterPublicFQDN", IsNullable = false, Namespace = "")]
    public string WebServerClusterPublicFQDN {
        get => _webServerClusterPublicFQDN;
        set {
            WebServerClusterPublicFQDNSpecified = true;
            _webServerClusterPublicFQDN = value;
        }
    }

    [XmlIgnore]
    public bool WebServerClusterPublicFQDNSpecified { get; set; }
    private string _applicationServerClusterPrimaryPublicFQDN;

    [XmlElement(ElementName = "applicationServerClusterPrimaryPublicFQDN", IsNullable = false, Namespace = "")]
    public string ApplicationServerClusterPrimaryPublicFQDN {
        get => _applicationServerClusterPrimaryPublicFQDN;
        set {
            ApplicationServerClusterPrimaryPublicFQDNSpecified = true;
            _applicationServerClusterPrimaryPublicFQDN = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationServerClusterPrimaryPublicFQDNSpecified { get; set; }
    private string _applicationServerClusterSecondaryPublicFQDN;

    [XmlElement(ElementName = "applicationServerClusterSecondaryPublicFQDN", IsNullable = false, Namespace = "")]
    public string ApplicationServerClusterSecondaryPublicFQDN {
        get => _applicationServerClusterSecondaryPublicFQDN;
        set {
            ApplicationServerClusterSecondaryPublicFQDNSpecified = true;
            _applicationServerClusterSecondaryPublicFQDN = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationServerClusterSecondaryPublicFQDNSpecified { get; set; }
    private string _applicationServerClusterPrimaryPrivateFQDN;

    [XmlElement(ElementName = "applicationServerClusterPrimaryPrivateFQDN", IsNullable = false, Namespace = "")]
    public string ApplicationServerClusterPrimaryPrivateFQDN {
        get => _applicationServerClusterPrimaryPrivateFQDN;
        set {
            ApplicationServerClusterPrimaryPrivateFQDNSpecified = true;
            _applicationServerClusterPrimaryPrivateFQDN = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationServerClusterPrimaryPrivateFQDNSpecified { get; set; }
    private string _applicationServerClusterSecondaryPrivateFQDN;

    [XmlElement(ElementName = "applicationServerClusterSecondaryPrivateFQDN", IsNullable = false, Namespace = "")]
    public string ApplicationServerClusterSecondaryPrivateFQDN {
        get => _applicationServerClusterSecondaryPrivateFQDN;
        set {
            ApplicationServerClusterSecondaryPrivateFQDNSpecified = true;
            _applicationServerClusterSecondaryPrivateFQDN = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationServerClusterSecondaryPrivateFQDNSpecified { get; set; }
}
}
