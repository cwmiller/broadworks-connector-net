using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberActivationModifyRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.NumberActivationMode _numberActivationMode;

    [XmlElement(ElementName = "numberActivationMode", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.NumberActivationMode NumberActivationMode {
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
