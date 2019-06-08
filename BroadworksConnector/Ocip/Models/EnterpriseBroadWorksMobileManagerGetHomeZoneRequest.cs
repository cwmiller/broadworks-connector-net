using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobileManagerGetHomeZoneRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _homeZoneId;

    [XmlElement(ElementName = "homeZoneId", IsNullable = false, Namespace = "")]
    public string HomeZoneId {
        get => _homeZoneId;
        set {
            HomeZoneIdSpecified = true;
            _homeZoneId = value;
        }
    }

    [XmlIgnore]
    public bool HomeZoneIdSpecified { get; set; }
}
}
