using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSubscriberGetCallProcessingParametersResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isExtendedCallingLineIdActive;

    [XmlElement(ElementName = "isExtendedCallingLineIdActive", IsNullable = false, Namespace = "")]
    public bool IsExtendedCallingLineIdActive {
        get => _isExtendedCallingLineIdActive;
        set {
            IsExtendedCallingLineIdActiveSpecified = true;
            _isExtendedCallingLineIdActive = value;
        }
    }

    [XmlIgnore]
    public bool IsExtendedCallingLineIdActiveSpecified { get; set; }
    private bool _isRingTimeOutActive;

    [XmlElement(ElementName = "isRingTimeOutActive", IsNullable = false, Namespace = "")]
    public bool IsRingTimeOutActive {
        get => _isRingTimeOutActive;
        set {
            IsRingTimeOutActiveSpecified = true;
            _isRingTimeOutActive = value;
        }
    }

    [XmlIgnore]
    public bool IsRingTimeOutActiveSpecified { get; set; }
    private int _ringTimeoutSeconds;

    [XmlElement(ElementName = "ringTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int RingTimeoutSeconds {
        get => _ringTimeoutSeconds;
        set {
            RingTimeoutSecondsSpecified = true;
            _ringTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RingTimeoutSecondsSpecified { get; set; }
    private bool _allowEmergencyRemoteOfficeOriginations;

    [XmlElement(ElementName = "allowEmergencyRemoteOfficeOriginations", IsNullable = false, Namespace = "")]
    public bool AllowEmergencyRemoteOfficeOriginations {
        get => _allowEmergencyRemoteOfficeOriginations;
        set {
            AllowEmergencyRemoteOfficeOriginationsSpecified = true;
            _allowEmergencyRemoteOfficeOriginations = value;
        }
    }

    [XmlIgnore]
    public bool AllowEmergencyRemoteOfficeOriginationsSpecified { get; set; }
    private int _maxNoAnswerNumberOfRings;

    [XmlElement(ElementName = "maxNoAnswerNumberOfRings", IsNullable = false, Namespace = "")]
    public int MaxNoAnswerNumberOfRings {
        get => _maxNoAnswerNumberOfRings;
        set {
            MaxNoAnswerNumberOfRingsSpecified = true;
            _maxNoAnswerNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool MaxNoAnswerNumberOfRingsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.IncomingCallToUserAliasMode _incomingCallToUserAliasMode;

    [XmlElement(ElementName = "incomingCallToUserAliasMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.IncomingCallToUserAliasMode IncomingCallToUserAliasMode {
        get => _incomingCallToUserAliasMode;
        set {
            IncomingCallToUserAliasModeSpecified = true;
            _incomingCallToUserAliasMode = value;
        }
    }

    [XmlIgnore]
    public bool IncomingCallToUserAliasModeSpecified { get; set; }
}
}
