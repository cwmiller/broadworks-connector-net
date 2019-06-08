using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseCallCenterCallDispositionCodeModifyActiveListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation> _callDispositionCodeActivation;

    [XmlElement(ElementName = "callDispositionCodeActivation", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CallDispositionCodeActivation> CallDispositionCodeActivation {
        get => _callDispositionCodeActivation;
        set {
            CallDispositionCodeActivationSpecified = true;
            _callDispositionCodeActivation = value;
        }
    }

    [XmlIgnore]
    public bool CallDispositionCodeActivationSpecified { get; set; }
}
}
