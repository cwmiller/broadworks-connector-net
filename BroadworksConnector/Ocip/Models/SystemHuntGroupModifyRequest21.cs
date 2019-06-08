using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHuntGroupModifyRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _removeHuntGroupNameFromCLID;

    [XmlElement(ElementName = "removeHuntGroupNameFromCLID", IsNullable = false, Namespace = "")]
    public bool RemoveHuntGroupNameFromCLID {
        get => _removeHuntGroupNameFromCLID;
        set {
            RemoveHuntGroupNameFromCLIDSpecified = true;
            _removeHuntGroupNameFromCLID = value;
        }
    }

    [XmlIgnore]
    public bool RemoveHuntGroupNameFromCLIDSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.HuntGroupUniformCallDistributionPolicyScope _uniformCallDistributionPolicyScope;

    [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.HuntGroupUniformCallDistributionPolicyScope UniformCallDistributionPolicyScope {
        get => _uniformCallDistributionPolicyScope;
        set {
            UniformCallDistributionPolicyScopeSpecified = true;
            _uniformCallDistributionPolicyScope = value;
        }
    }

    [XmlIgnore]
    public bool UniformCallDistributionPolicyScopeSpecified { get; set; }
    private bool _allowAgentDeviceInitiatedForward;

    [XmlElement(ElementName = "allowAgentDeviceInitiatedForward", IsNullable = false, Namespace = "")]
    public bool AllowAgentDeviceInitiatedForward {
        get => _allowAgentDeviceInitiatedForward;
        set {
            AllowAgentDeviceInitiatedForwardSpecified = true;
            _allowAgentDeviceInitiatedForward = value;
        }
    }

    [XmlIgnore]
    public bool AllowAgentDeviceInitiatedForwardSpecified { get; set; }
}
}
