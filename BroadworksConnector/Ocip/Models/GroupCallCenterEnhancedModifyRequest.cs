using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterEnhancedModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private bool _overrideAgentWrapUpTime;

    [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false, Namespace = "")]
    public bool OverrideAgentWrapUpTime {
        get => _overrideAgentWrapUpTime;
        set {
            OverrideAgentWrapUpTimeSpecified = true;
            _overrideAgentWrapUpTime = value;
        }
    }

    [XmlIgnore]
    public bool OverrideAgentWrapUpTimeSpecified { get; set; }
    private int? _wrapUpSeconds;

    [XmlElement(ElementName = "wrapUpSeconds", IsNullable = true, Namespace = "")]
    public int? WrapUpSeconds {
        get => _wrapUpSeconds;
        set {
            WrapUpSecondsSpecified = true;
            _wrapUpSeconds = value;
        }
    }

    [XmlIgnore]
    public bool WrapUpSecondsSpecified { get; set; }
}
}
