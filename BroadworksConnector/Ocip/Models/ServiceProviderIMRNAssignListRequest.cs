using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderIMRNAssignListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<string> _imrn;

    [XmlElement(ElementName = "imrn", IsNullable = false, Namespace = "")]
    public List<string> Imrn {
        get => _imrn;
        set {
            ImrnSpecified = true;
            _imrn = value;
        }
    }

    [XmlIgnore]
    public bool ImrnSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.DNRange> _imrnRange;

    [XmlElement(ElementName = "imrnRange", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.DNRange> ImrnRange {
        get => _imrnRange;
        set {
            ImrnRangeSpecified = true;
            _imrnRange = value;
        }
    }

    [XmlIgnore]
    public bool ImrnRangeSpecified { get; set; }
}
}
