using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberDeleteListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _mobileSubscriberDirectoryNumber;

    [XmlElement(ElementName = "mobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
    public List<string> MobileSubscriberDirectoryNumber {
        get => _mobileSubscriberDirectoryNumber;
        set {
            MobileSubscriberDirectoryNumberSpecified = true;
            _mobileSubscriberDirectoryNumber = value;
        }
    }

    [XmlIgnore]
    public bool MobileSubscriberDirectoryNumberSpecified { get; set; }
}
}
