using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserDevicePoliciesGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.UserDevicePolicyLineMode _lineMode;

    [XmlElement(ElementName = "lineMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.UserDevicePolicyLineMode LineMode {
        get => _lineMode;
        set {
            LineModeSpecified = true;
            _lineMode = value;
        }
    }

    [XmlIgnore]
    public bool LineModeSpecified { get; set; }
    private bool _enableDeviceFeatureSynchronization;

    [XmlElement(ElementName = "enableDeviceFeatureSynchronization", IsNullable = false, Namespace = "")]
    public bool EnableDeviceFeatureSynchronization {
        get => _enableDeviceFeatureSynchronization;
        set {
            EnableDeviceFeatureSynchronizationSpecified = true;
            _enableDeviceFeatureSynchronization = value;
        }
    }

    [XmlIgnore]
    public bool EnableDeviceFeatureSynchronizationSpecified { get; set; }
}
}
