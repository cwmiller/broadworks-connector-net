using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOutgoingCallingPlanGetResponse17sp3 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _directTransferScreening;

    [XmlElement(ElementName = "directTransferScreening", IsNullable = false, Namespace = "")]
    public bool DirectTransferScreening {
        get => _directTransferScreening;
        set {
            DirectTransferScreeningSpecified = true;
            _directTransferScreening = value;
        }
    }

    [XmlIgnore]
    public bool DirectTransferScreeningSpecified { get; set; }
    private bool _enableEnhancedTollCallTyping;

    [XmlElement(ElementName = "enableEnhancedTollCallTyping", IsNullable = false, Namespace = "")]
    public bool EnableEnhancedTollCallTyping {
        get => _enableEnhancedTollCallTyping;
        set {
            EnableEnhancedTollCallTypingSpecified = true;
            _enableEnhancedTollCallTyping = value;
        }
    }

    [XmlIgnore]
    public bool EnableEnhancedTollCallTypingSpecified { get; set; }
}
}
