using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private int _recallTimerSeconds;

    [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false, Namespace = "")]
    public int RecallTimerSeconds {
        get => _recallTimerSeconds;
        set {
            RecallTimerSecondsSpecified = true;
            _recallTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RecallTimerSecondsSpecified { get; set; }
    private int _displayTimerSeconds;

    [XmlElement(ElementName = "displayTimerSeconds", IsNullable = false, Namespace = "")]
    public int DisplayTimerSeconds {
        get => _displayTimerSeconds;
        set {
            DisplayTimerSecondsSpecified = true;
            _displayTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool DisplayTimerSecondsSpecified { get; set; }
    private bool _enableDestinationAnnouncement;

    [XmlElement(ElementName = "enableDestinationAnnouncement", IsNullable = false, Namespace = "")]
    public bool EnableDestinationAnnouncement {
        get => _enableDestinationAnnouncement;
        set {
            EnableDestinationAnnouncementSpecified = true;
            _enableDestinationAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool EnableDestinationAnnouncementSpecified { get; set; }
    private string _recallAlternateUserId;

    [XmlElement(ElementName = "recallAlternateUserId", IsNullable = true, Namespace = "")]
    public string RecallAlternateUserId {
        get => _recallAlternateUserId;
        set {
            RecallAlternateUserIdSpecified = true;
            _recallAlternateUserId = value;
        }
    }

    [XmlIgnore]
    public bool RecallAlternateUserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.RingPattern _recallRingPattern;

    [XmlElement(ElementName = "recallRingPattern", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RingPattern RecallRingPattern {
        get => _recallRingPattern;
        set {
            RecallRingPatternSpecified = true;
            _recallRingPattern = value;
        }
    }

    [XmlIgnore]
    public bool RecallRingPatternSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallParkRecallTo _recallTo;

    [XmlElement(ElementName = "recallTo", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallParkRecallTo RecallTo {
        get => _recallTo;
        set {
            RecallToSpecified = true;
            _recallTo = value;
        }
    }

    [XmlIgnore]
    public bool RecallToSpecified { get; set; }
    private int _alternateUserRecallTimerSeconds;

    [XmlElement(ElementName = "alternateUserRecallTimerSeconds", IsNullable = false, Namespace = "")]
    public int AlternateUserRecallTimerSeconds {
        get => _alternateUserRecallTimerSeconds;
        set {
            AlternateUserRecallTimerSecondsSpecified = true;
            _alternateUserRecallTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool AlternateUserRecallTimerSecondsSpecified { get; set; }
}
}
