using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementInProgressAndPendingEventCancelRequestCancelMultipleEvents 
{
    private BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusForCancel _dmEventStatusForCancel;

    [XmlElement(ElementName = "dmEventStatusForCancel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementEventStatusForCancel DmEventStatusForCancel {
        get => _dmEventStatusForCancel;
        set {
            DmEventStatusForCancelSpecified = true;
            _dmEventStatusForCancel = value;
        }
    }

    [XmlIgnore]
    public bool DmEventStatusForCancelSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementEventAction _dmEventAction;

    [XmlElement(ElementName = "dmEventAction", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementEventAction DmEventAction {
        get => _dmEventAction;
        set {
            DmEventActionSpecified = true;
            _dmEventAction = value;
        }
    }

    [XmlIgnore]
    public bool DmEventActionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel _dmEventLevel;

    [XmlElement(ElementName = "dmEventLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementEventLevel DmEventLevel {
        get => _dmEventLevel;
        set {
            DmEventLevelSpecified = true;
            _dmEventLevel = value;
        }
    }

    [XmlIgnore]
    public bool DmEventLevelSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DeviceManagementEventType _dmEventType;

    [XmlElement(ElementName = "dmEventType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DeviceManagementEventType DmEventType {
        get => _dmEventType;
        set {
            DmEventTypeSpecified = true;
            _dmEventType = value;
        }
    }

    [XmlIgnore]
    public bool DmEventTypeSpecified { get; set; }
}
}
