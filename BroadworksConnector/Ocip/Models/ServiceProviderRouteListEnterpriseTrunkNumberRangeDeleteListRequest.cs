using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderRouteListEnterpriseTrunkNumberRangeDeleteListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _numberRangeStart;

    [XmlElement(ElementName = "numberRangeStart", IsNullable = false, Namespace = "")]
    public List<string> NumberRangeStart {
        get => _numberRangeStart;
        set {
            NumberRangeStartSpecified = true;
            _numberRangeStart = value;
        }
    }

    [XmlIgnore]
    public bool NumberRangeStartSpecified { get; set; }
}
}
