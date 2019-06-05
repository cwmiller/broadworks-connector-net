using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserMeetMeConferencingAddConferenceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _bridgeId;

    [XmlElement(ElementName = "bridgeId", IsNullable = false, Namespace = "")]
    public string BridgeId {
        get => _bridgeId;
        set {
            BridgeIdSpecified = true;
            _bridgeId = value;
        }
    }

    [XmlIgnore]
    public bool BridgeIdSpecified { get; set; }
    private string _title;

    [XmlElement(ElementName = "title", IsNullable = false, Namespace = "")]
    public string Title {
        get => _title;
        set {
            TitleSpecified = true;
            _title = value;
        }
    }

    [XmlIgnore]
    public bool TitleSpecified { get; set; }
    private int _estimatedParticipants;

    [XmlElement(ElementName = "estimatedParticipants", IsNullable = false, Namespace = "")]
    public int EstimatedParticipants {
        get => _estimatedParticipants;
        set {
            EstimatedParticipantsSpecified = true;
            _estimatedParticipants = value;
        }
    }

    [XmlIgnore]
    public bool EstimatedParticipantsSpecified { get; set; }
    private bool _restrictParticipants;

    [XmlElement(ElementName = "restrictParticipants", IsNullable = false, Namespace = "")]
    public bool RestrictParticipants {
        get => _restrictParticipants;
        set {
            RestrictParticipantsSpecified = true;
            _restrictParticipants = value;
        }
    }

    [XmlIgnore]
    public bool RestrictParticipantsSpecified { get; set; }
    private int _maxParticipants;

    [XmlElement(ElementName = "maxParticipants", IsNullable = false, Namespace = "")]
    public int MaxParticipants {
        get => _maxParticipants;
        set {
            MaxParticipantsSpecified = true;
            _maxParticipants = value;
        }
    }

    [XmlIgnore]
    public bool MaxParticipantsSpecified { get; set; }
    private string _accountCode;

    [XmlElement(ElementName = "accountCode", IsNullable = false, Namespace = "")]
    public string AccountCode {
        get => _accountCode;
        set {
            AccountCodeSpecified = true;
            _accountCode = value;
        }
    }

    [XmlIgnore]
    public bool AccountCodeSpecified { get; set; }
    private bool _muteAllAttendeesOnEntry;

    [XmlElement(ElementName = "muteAllAttendeesOnEntry", IsNullable = false, Namespace = "")]
    public bool MuteAllAttendeesOnEntry {
        get => _muteAllAttendeesOnEntry;
        set {
            MuteAllAttendeesOnEntrySpecified = true;
            _muteAllAttendeesOnEntry = value;
        }
    }

    [XmlIgnore]
    public bool MuteAllAttendeesOnEntrySpecified { get; set; }
    private bool _endConferenceOnModeratorExit;

    [XmlElement(ElementName = "endConferenceOnModeratorExit", IsNullable = false, Namespace = "")]
    public bool EndConferenceOnModeratorExit {
        get => _endConferenceOnModeratorExit;
        set {
            EndConferenceOnModeratorExitSpecified = true;
            _endConferenceOnModeratorExit = value;
        }
    }

    [XmlIgnore]
    public bool EndConferenceOnModeratorExitSpecified { get; set; }
    private bool _moderatorRequired;

    [XmlElement(ElementName = "moderatorRequired", IsNullable = false, Namespace = "")]
    public bool ModeratorRequired {
        get => _moderatorRequired;
        set {
            ModeratorRequiredSpecified = true;
            _moderatorRequired = value;
        }
    }

    [XmlIgnore]
    public bool ModeratorRequiredSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceAttendeeNotification _attendeeNotification;

    [XmlElement(ElementName = "attendeeNotification", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceAttendeeNotification AttendeeNotification {
        get => _attendeeNotification;
        set {
            AttendeeNotificationSpecified = true;
            _attendeeNotification = value;
        }
    }

    [XmlIgnore]
    public bool AttendeeNotificationSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceSchedule _conferenceSchedule;

    [XmlElement(ElementName = "conferenceSchedule", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceSchedule ConferenceSchedule {
        get => _conferenceSchedule;
        set {
            ConferenceScheduleSpecified = true;
            _conferenceSchedule = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceScheduleSpecified { get; set; }
}
}
