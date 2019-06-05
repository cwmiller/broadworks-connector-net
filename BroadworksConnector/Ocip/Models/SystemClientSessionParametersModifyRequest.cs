using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClientSessionParametersModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private bool _enableInactivityTimeout;

    [XmlElement(ElementName = "enableInactivityTimeout", IsNullable = false, Namespace = "")]
    public bool EnableInactivityTimeout {
        get => _enableInactivityTimeout;
        set {
            EnableInactivityTimeoutSpecified = true;
            _enableInactivityTimeout = value;
        }
    }

    [XmlIgnore]
    public bool EnableInactivityTimeoutSpecified { get; set; }
    private int _inactivityTimeoutMinutes;

    [XmlElement(ElementName = "inactivityTimeoutMinutes", IsNullable = false, Namespace = "")]
    public int InactivityTimeoutMinutes {
        get => _inactivityTimeoutMinutes;
        set {
            InactivityTimeoutMinutesSpecified = true;
            _inactivityTimeoutMinutes = value;
        }
    }

    [XmlIgnore]
    public bool InactivityTimeoutMinutesSpecified { get; set; }
}
}
