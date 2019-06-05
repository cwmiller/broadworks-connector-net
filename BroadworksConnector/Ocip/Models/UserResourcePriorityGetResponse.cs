using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserResourcePriorityGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useDefaultResourcePriority;

    [XmlElement(ElementName = "useDefaultResourcePriority", IsNullable = false, Namespace = "")]
    public bool UseDefaultResourcePriority {
        get => _useDefaultResourcePriority;
        set {
            UseDefaultResourcePrioritySpecified = true;
            _useDefaultResourcePriority = value;
        }
    }

    [XmlIgnore]
    public bool UseDefaultResourcePrioritySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ResourcePriorityValue _defaultResourcePriority;

    [XmlElement(ElementName = "defaultResourcePriority", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ResourcePriorityValue DefaultResourcePriority {
        get => _defaultResourcePriority;
        set {
            DefaultResourcePrioritySpecified = true;
            _defaultResourcePriority = value;
        }
    }

    [XmlIgnore]
    public bool DefaultResourcePrioritySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ResourcePriorityValue _userResourcePriority;

    [XmlElement(ElementName = "userResourcePriority", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ResourcePriorityValue UserResourcePriority {
        get => _userResourcePriority;
        set {
            UserResourcePrioritySpecified = true;
            _userResourcePriority = value;
        }
    }

    [XmlIgnore]
    public bool UserResourcePrioritySpecified { get; set; }
}
}
