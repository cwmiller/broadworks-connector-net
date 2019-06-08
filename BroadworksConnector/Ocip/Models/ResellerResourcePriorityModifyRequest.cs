using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerResourcePriorityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
    private bool _useSystemSettings;

    [XmlElement(ElementName = "useSystemSettings", IsNullable = false, Namespace = "")]
    public bool UseSystemSettings {
        get => _useSystemSettings;
        set {
            UseSystemSettingsSpecified = true;
            _useSystemSettings = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemSettingsSpecified { get; set; }
    private bool _sendResourcePriorityToNetwork;

    [XmlElement(ElementName = "sendResourcePriorityToNetwork", IsNullable = false, Namespace = "")]
    public bool SendResourcePriorityToNetwork {
        get => _sendResourcePriorityToNetwork;
        set {
            SendResourcePriorityToNetworkSpecified = true;
            _sendResourcePriorityToNetwork = value;
        }
    }

    [XmlIgnore]
    public bool SendResourcePriorityToNetworkSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ResourcePriorityValue _resourcePriority;

    [XmlElement(ElementName = "resourcePriority", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ResourcePriorityValue ResourcePriority {
        get => _resourcePriority;
        set {
            ResourcePrioritySpecified = true;
            _resourcePriority = value;
        }
    }

    [XmlIgnore]
    public bool ResourcePrioritySpecified { get; set; }
}
}
