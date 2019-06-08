using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCICallControlApplicationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _applicationId;

    [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
    public string ApplicationId {
        get => _applicationId;
        set {
            ApplicationIdSpecified = true;
            _applicationId = value;
        }
    }

    [XmlIgnore]
    public bool ApplicationIdSpecified { get; set; }
    private bool _enableSystemWide;

    [XmlElement(ElementName = "enableSystemWide", IsNullable = false, Namespace = "")]
    public bool EnableSystemWide {
        get => _enableSystemWide;
        set {
            EnableSystemWideSpecified = true;
            _enableSystemWide = value;
        }
    }

    [XmlIgnore]
    public bool EnableSystemWideSpecified { get; set; }
    private int _notificationTimeoutSeconds;

    [XmlElement(ElementName = "notificationTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int NotificationTimeoutSeconds {
        get => _notificationTimeoutSeconds;
        set {
            NotificationTimeoutSecondsSpecified = true;
            _notificationTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool NotificationTimeoutSecondsSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private int _maxEventChannelsPerSet;

    [XmlElement(ElementName = "maxEventChannelsPerSet", IsNullable = false, Namespace = "")]
    public int MaxEventChannelsPerSet {
        get => _maxEventChannelsPerSet;
        set {
            MaxEventChannelsPerSetSpecified = true;
            _maxEventChannelsPerSet = value;
        }
    }

    [XmlIgnore]
    public bool MaxEventChannelsPerSetSpecified { get; set; }
    private int _unresponsiveChannelSetGracePeriodSeconds;

    [XmlElement(ElementName = "unresponsiveChannelSetGracePeriodSeconds", IsNullable = false, Namespace = "")]
    public int UnresponsiveChannelSetGracePeriodSeconds {
        get => _unresponsiveChannelSetGracePeriodSeconds;
        set {
            UnresponsiveChannelSetGracePeriodSecondsSpecified = true;
            _unresponsiveChannelSetGracePeriodSeconds = value;
        }
    }

    [XmlIgnore]
    public bool UnresponsiveChannelSetGracePeriodSecondsSpecified { get; set; }
}
}
