using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExecutiveGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _treatVirtualOnNetCallsAsInternal;

    [XmlElement(ElementName = "treatVirtualOnNetCallsAsInternal", IsNullable = false, Namespace = "")]
    public bool TreatVirtualOnNetCallsAsInternal {
        get => _treatVirtualOnNetCallsAsInternal;
        set {
            TreatVirtualOnNetCallsAsInternalSpecified = true;
            _treatVirtualOnNetCallsAsInternal = value;
        }
    }

    [XmlIgnore]
    public bool TreatVirtualOnNetCallsAsInternalSpecified { get; set; }
}
}
