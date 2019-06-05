using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberActivationModifyRequest18sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.NumberActivationMode _numberActivationMode;

    [XmlElement(ElementName = "numberActivationMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NumberActivationMode NumberActivationMode {
        get => _numberActivationMode;
        set {
            NumberActivationModeSpecified = true;
            _numberActivationMode = value;
        }
    }

    [XmlIgnore]
    public bool NumberActivationModeSpecified { get; set; }
    private bool _enableEnterpriseTrunkNumberRangeActivation;

    [XmlElement(ElementName = "enableEnterpriseTrunkNumberRangeActivation", IsNullable = false, Namespace = "")]
    public bool EnableEnterpriseTrunkNumberRangeActivation {
        get => _enableEnterpriseTrunkNumberRangeActivation;
        set {
            EnableEnterpriseTrunkNumberRangeActivationSpecified = true;
            _enableEnterpriseTrunkNumberRangeActivation = value;
        }
    }

    [XmlIgnore]
    public bool EnableEnterpriseTrunkNumberRangeActivationSpecified { get; set; }
}
}
