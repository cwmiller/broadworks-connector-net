using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupMeetMeConferencingModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts _allocatedPorts;

    [XmlElement(ElementName = "allocatedPorts", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferencePorts AllocatedPorts {
        get => _allocatedPorts;
        set {
            AllocatedPortsSpecified = true;
            _allocatedPorts = value;
        }
    }

    [XmlIgnore]
    public bool AllocatedPortsSpecified { get; set; }
    private string _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public string NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
    private int _securityPinLength;

    [XmlElement(ElementName = "securityPinLength", IsNullable = false, Namespace = "")]
    public int SecurityPinLength {
        get => _securityPinLength;
        set {
            SecurityPinLengthSpecified = true;
            _securityPinLength = value;
        }
    }

    [XmlIgnore]
    public bool SecurityPinLengthSpecified { get; set; }
    private bool _allowIndividualOutDial;

    [XmlElement(ElementName = "allowIndividualOutDial", IsNullable = false, Namespace = "")]
    public bool AllowIndividualOutDial {
        get => _allowIndividualOutDial;
        set {
            AllowIndividualOutDialSpecified = true;
            _allowIndividualOutDial = value;
        }
    }

    [XmlIgnore]
    public bool AllowIndividualOutDialSpecified { get; set; }
    private string _operatorNumber;

    [XmlElement(ElementName = "operatorNumber", IsNullable = true, Namespace = "")]
    public string OperatorNumber {
        get => _operatorNumber;
        set {
            OperatorNumberSpecified = true;
            _operatorNumber = value;
        }
    }

    [XmlIgnore]
    public bool OperatorNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _conferenceHostUserIdList;

    [XmlElement(ElementName = "conferenceHostUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList ConferenceHostUserIdList {
        get => _conferenceHostUserIdList;
        set {
            ConferenceHostUserIdListSpecified = true;
            _conferenceHostUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceHostUserIdListSpecified { get; set; }
    private bool _playWarningPrompt;

    [XmlElement(ElementName = "playWarningPrompt", IsNullable = false, Namespace = "")]
    public bool PlayWarningPrompt {
        get => _playWarningPrompt;
        set {
            PlayWarningPromptSpecified = true;
            _playWarningPrompt = value;
        }
    }

    [XmlIgnore]
    public bool PlayWarningPromptSpecified { get; set; }
    private int _conferenceEndWarningPromptMinutes;

    [XmlElement(ElementName = "conferenceEndWarningPromptMinutes", IsNullable = false, Namespace = "")]
    public int ConferenceEndWarningPromptMinutes {
        get => _conferenceEndWarningPromptMinutes;
        set {
            ConferenceEndWarningPromptMinutesSpecified = true;
            _conferenceEndWarningPromptMinutes = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceEndWarningPromptMinutesSpecified { get; set; }
    private bool _enableMaxConferenceDuration;

    [XmlElement(ElementName = "enableMaxConferenceDuration", IsNullable = false, Namespace = "")]
    public bool EnableMaxConferenceDuration {
        get => _enableMaxConferenceDuration;
        set {
            EnableMaxConferenceDurationSpecified = true;
            _enableMaxConferenceDuration = value;
        }
    }

    [XmlIgnore]
    public bool EnableMaxConferenceDurationSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _maxConferenceDurationMinutes;

    [XmlElement(ElementName = "maxConferenceDurationMinutes", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceDuration MaxConferenceDurationMinutes {
        get => _maxConferenceDurationMinutes;
        set {
            MaxConferenceDurationMinutesSpecified = true;
            _maxConferenceDurationMinutes = value;
        }
    }

    [XmlIgnore]
    public bool MaxConferenceDurationMinutesSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _maxScheduledConferenceDurationMinutes;

    [XmlElement(ElementName = "maxScheduledConferenceDurationMinutes", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MeetMeConferencingConferenceDuration MaxScheduledConferenceDurationMinutes {
        get => _maxScheduledConferenceDurationMinutes;
        set {
            MaxScheduledConferenceDurationMinutesSpecified = true;
            _maxScheduledConferenceDurationMinutes = value;
        }
    }

    [XmlIgnore]
    public bool MaxScheduledConferenceDurationMinutesSpecified { get; set; }
}
}
