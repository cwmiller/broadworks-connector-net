using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterQueueStatusNotificationModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _enableQueueStatusNotification;

    [XmlElement(ElementName = "enableQueueStatusNotification", IsNullable = false, Namespace = "")]
    public bool EnableQueueStatusNotification {
        get => _enableQueueStatusNotification;
        set {
            EnableQueueStatusNotificationSpecified = true;
            _enableQueueStatusNotification = value;
        }
    }

    [XmlIgnore]
    public bool EnableQueueStatusNotificationSpecified { get; set; }
    private bool _enableQueueDepthThreshold;

    [XmlElement(ElementName = "enableQueueDepthThreshold", IsNullable = false, Namespace = "")]
    public bool EnableQueueDepthThreshold {
        get => _enableQueueDepthThreshold;
        set {
            EnableQueueDepthThresholdSpecified = true;
            _enableQueueDepthThreshold = value;
        }
    }

    [XmlIgnore]
    public bool EnableQueueDepthThresholdSpecified { get; set; }
    private bool _enableWaitingTimeThreshold;

    [XmlElement(ElementName = "enableWaitingTimeThreshold", IsNullable = false, Namespace = "")]
    public bool EnableWaitingTimeThreshold {
        get => _enableWaitingTimeThreshold;
        set {
            EnableWaitingTimeThresholdSpecified = true;
            _enableWaitingTimeThreshold = value;
        }
    }

    [XmlIgnore]
    public bool EnableWaitingTimeThresholdSpecified { get; set; }
    private int _numberOfCallsThreshold;

    [XmlElement(ElementName = "numberOfCallsThreshold", IsNullable = false, Namespace = "")]
    public int NumberOfCallsThreshold {
        get => _numberOfCallsThreshold;
        set {
            NumberOfCallsThresholdSpecified = true;
            _numberOfCallsThreshold = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfCallsThresholdSpecified { get; set; }
    private int _waitingTimeOfCallsThreshold;

    [XmlElement(ElementName = "waitingTimeOfCallsThreshold", IsNullable = false, Namespace = "")]
    public int WaitingTimeOfCallsThreshold {
        get => _waitingTimeOfCallsThreshold;
        set {
            WaitingTimeOfCallsThresholdSpecified = true;
            _waitingTimeOfCallsThreshold = value;
        }
    }

    [XmlIgnore]
    public bool WaitingTimeOfCallsThresholdSpecified { get; set; }
}
}
