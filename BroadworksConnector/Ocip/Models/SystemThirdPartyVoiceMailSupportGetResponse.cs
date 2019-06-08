using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyVoiceMailSupportGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _overrideAltCallerIdForVMRetrieval;

    [XmlElement(ElementName = "overrideAltCallerIdForVMRetrieval", IsNullable = false, Namespace = "")]
    public bool OverrideAltCallerIdForVMRetrieval {
        get => _overrideAltCallerIdForVMRetrieval;
        set {
            OverrideAltCallerIdForVMRetrievalSpecified = true;
            _overrideAltCallerIdForVMRetrieval = value;
        }
    }

    [XmlIgnore]
    public bool OverrideAltCallerIdForVMRetrievalSpecified { get; set; }
}
}
