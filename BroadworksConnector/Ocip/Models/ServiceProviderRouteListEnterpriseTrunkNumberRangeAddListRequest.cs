using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderRouteListEnterpriseTrunkNumberRangeAddListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.DNRange> _numberRange;

    [XmlElement(ElementName = "numberRange", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.DNRange> NumberRange {
        get => _numberRange;
        set {
            NumberRangeSpecified = true;
            _numberRange = value;
        }
    }

    [XmlIgnore]
    public bool NumberRangeSpecified { get; set; }
}
}
