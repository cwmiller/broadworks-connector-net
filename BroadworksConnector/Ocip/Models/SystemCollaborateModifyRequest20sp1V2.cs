using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCollaborateModifyRequest20sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private int _collaborateRoomIdLength;

    [XmlElement(ElementName = "collaborateRoomIdLength", IsNullable = false, Namespace = "")]
    public int CollaborateRoomIdLength {
        get => _collaborateRoomIdLength;
        set {
            CollaborateRoomIdLengthSpecified = true;
            _collaborateRoomIdLength = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateRoomIdLengthSpecified { get; set; }
    private int _instantRoomIdleTimeoutSeconds;

    [XmlElement(ElementName = "instantRoomIdleTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int InstantRoomIdleTimeoutSeconds {
        get => _instantRoomIdleTimeoutSeconds;
        set {
            InstantRoomIdleTimeoutSecondsSpecified = true;
            _instantRoomIdleTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool InstantRoomIdleTimeoutSecondsSpecified { get; set; }
    private int _collaborateRoomMaximumDurationMinutes;

    [XmlElement(ElementName = "collaborateRoomMaximumDurationMinutes", IsNullable = false, Namespace = "")]
    public int CollaborateRoomMaximumDurationMinutes {
        get => _collaborateRoomMaximumDurationMinutes;
        set {
            CollaborateRoomMaximumDurationMinutesSpecified = true;
            _collaborateRoomMaximumDurationMinutes = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateRoomMaximumDurationMinutesSpecified { get; set; }
    private bool _supportOutdial;

    [XmlElement(ElementName = "supportOutdial", IsNullable = false, Namespace = "")]
    public bool SupportOutdial {
        get => _supportOutdial;
        set {
            SupportOutdialSpecified = true;
            _supportOutdial = value;
        }
    }

    [XmlIgnore]
    public bool SupportOutdialSpecified { get; set; }
    private int _maxCollaborateRoomParticipants;

    [XmlElement(ElementName = "maxCollaborateRoomParticipants", IsNullable = false, Namespace = "")]
    public int MaxCollaborateRoomParticipants {
        get => _maxCollaborateRoomParticipants;
        set {
            MaxCollaborateRoomParticipantsSpecified = true;
            _maxCollaborateRoomParticipants = value;
        }
    }

    [XmlIgnore]
    public bool MaxCollaborateRoomParticipantsSpecified { get; set; }
    private int _collaborateActiveTalkerRefreshIntervalSeconds;

    [XmlElement(ElementName = "collaborateActiveTalkerRefreshIntervalSeconds", IsNullable = false, Namespace = "")]
    public int CollaborateActiveTalkerRefreshIntervalSeconds {
        get => _collaborateActiveTalkerRefreshIntervalSeconds;
        set {
            CollaborateActiveTalkerRefreshIntervalSecondsSpecified = true;
            _collaborateActiveTalkerRefreshIntervalSeconds = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateActiveTalkerRefreshIntervalSecondsSpecified { get; set; }
    private bool _terminateCollaborateAfterGracePeriod;

    [XmlElement(ElementName = "terminateCollaborateAfterGracePeriod", IsNullable = false, Namespace = "")]
    public bool TerminateCollaborateAfterGracePeriod {
        get => _terminateCollaborateAfterGracePeriod;
        set {
            TerminateCollaborateAfterGracePeriodSpecified = true;
            _terminateCollaborateAfterGracePeriod = value;
        }
    }

    [XmlIgnore]
    public bool TerminateCollaborateAfterGracePeriodSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CollaborateGracePeriodDuration _collaborateGracePeriod;

    [XmlElement(ElementName = "collaborateGracePeriod", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CollaborateGracePeriodDuration CollaborateGracePeriod {
        get => _collaborateGracePeriod;
        set {
            CollaborateGracePeriodSpecified = true;
            _collaborateGracePeriod = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateGracePeriodSpecified { get; set; }
    private bool _enableActiveCollaborateNotification;

    [XmlElement(ElementName = "enableActiveCollaborateNotification", IsNullable = false, Namespace = "")]
    public bool EnableActiveCollaborateNotification {
        get => _enableActiveCollaborateNotification;
        set {
            EnableActiveCollaborateNotificationSpecified = true;
            _enableActiveCollaborateNotification = value;
        }
    }

    [XmlIgnore]
    public bool EnableActiveCollaborateNotificationSpecified { get; set; }
    private string _collaborateFromAddress;

    [XmlElement(ElementName = "collaborateFromAddress", IsNullable = true, Namespace = "")]
    public string CollaborateFromAddress {
        get => _collaborateFromAddress;
        set {
            CollaborateFromAddressSpecified = true;
            _collaborateFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateFromAddressSpecified { get; set; }
}
}
