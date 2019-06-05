using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupGetInstanceResponse14sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
    private int _maxActiveCalls;

    [XmlElement(ElementName = "maxActiveCalls", IsNullable = false, Namespace = "")]
    public int MaxActiveCalls {
        get => _maxActiveCalls;
        set {
            MaxActiveCallsSpecified = true;
            _maxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxActiveCallsSpecified { get; set; }
    private int _maxIncomingCalls;

    [XmlElement(ElementName = "maxIncomingCalls", IsNullable = false, Namespace = "")]
    public int MaxIncomingCalls {
        get => _maxIncomingCalls;
        set {
            MaxIncomingCallsSpecified = true;
            _maxIncomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxIncomingCallsSpecified { get; set; }
    private int _maxOutgoingCalls;

    [XmlElement(ElementName = "maxOutgoingCalls", IsNullable = false, Namespace = "")]
    public int MaxOutgoingCalls {
        get => _maxOutgoingCalls;
        set {
            MaxOutgoingCallsSpecified = true;
            _maxOutgoingCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxOutgoingCallsSpecified { get; set; }
    private bool _enableBursting;

    [XmlElement(ElementName = "enableBursting", IsNullable = false, Namespace = "")]
    public bool EnableBursting {
        get => _enableBursting;
        set {
            EnableBurstingSpecified = true;
            _enableBursting = value;
        }
    }

    [XmlIgnore]
    public bool EnableBurstingSpecified { get; set; }
    private int _burstingMaxActiveCalls;

    [XmlElement(ElementName = "burstingMaxActiveCalls", IsNullable = false, Namespace = "")]
    public int BurstingMaxActiveCalls {
        get => _burstingMaxActiveCalls;
        set {
            BurstingMaxActiveCallsSpecified = true;
            _burstingMaxActiveCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxActiveCallsSpecified { get; set; }
    private int _burstingMaxIncomingCalls;

    [XmlElement(ElementName = "burstingMaxIncomingCalls", IsNullable = false, Namespace = "")]
    public int BurstingMaxIncomingCalls {
        get => _burstingMaxIncomingCalls;
        set {
            BurstingMaxIncomingCallsSpecified = true;
            _burstingMaxIncomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxIncomingCallsSpecified { get; set; }
    private int _burstingMaxOutgoingCalls;

    [XmlElement(ElementName = "burstingMaxOutgoingCalls", IsNullable = false, Namespace = "")]
    public int BurstingMaxOutgoingCalls {
        get => _burstingMaxOutgoingCalls;
        set {
            BurstingMaxOutgoingCallsSpecified = true;
            _burstingMaxOutgoingCalls = value;
        }
    }

    [XmlIgnore]
    public bool BurstingMaxOutgoingCallsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkGroupCapacityExceededAction _capacityExceededAction;

    [XmlElement(ElementName = "capacityExceededAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupCapacityExceededAction CapacityExceededAction {
        get => _capacityExceededAction;
        set {
            CapacityExceededActionSpecified = true;
            _capacityExceededAction = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededActionSpecified { get; set; }
    private string _capacityExceededForwardAddress;

    [XmlElement(ElementName = "capacityExceededForwardAddress", IsNullable = false, Namespace = "")]
    public string CapacityExceededForwardAddress {
        get => _capacityExceededForwardAddress;
        set {
            CapacityExceededForwardAddressSpecified = true;
            _capacityExceededForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededForwardAddressSpecified { get; set; }
    private string _capacityExceededRerouteTrunkGroupId;

    [XmlElement(ElementName = "capacityExceededRerouteTrunkGroupId", IsNullable = false, Namespace = "")]
    public string CapacityExceededRerouteTrunkGroupId {
        get => _capacityExceededRerouteTrunkGroupId;
        set {
            CapacityExceededRerouteTrunkGroupIdSpecified = true;
            _capacityExceededRerouteTrunkGroupId = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededRerouteTrunkGroupIdSpecified { get; set; }
    private int _capacityExceededTrapInitialCalls;

    [XmlElement(ElementName = "capacityExceededTrapInitialCalls", IsNullable = false, Namespace = "")]
    public int CapacityExceededTrapInitialCalls {
        get => _capacityExceededTrapInitialCalls;
        set {
            CapacityExceededTrapInitialCallsSpecified = true;
            _capacityExceededTrapInitialCalls = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededTrapInitialCallsSpecified { get; set; }
    private int _capacityExceededTrapOffsetCalls;

    [XmlElement(ElementName = "capacityExceededTrapOffsetCalls", IsNullable = false, Namespace = "")]
    public int CapacityExceededTrapOffsetCalls {
        get => _capacityExceededTrapOffsetCalls;
        set {
            CapacityExceededTrapOffsetCallsSpecified = true;
            _capacityExceededTrapOffsetCalls = value;
        }
    }

    [XmlIgnore]
    public bool CapacityExceededTrapOffsetCallsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction _unreachableDestinationAction;

    [XmlElement(ElementName = "unreachableDestinationAction", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TrunkGroupUnreachableDestinationAction UnreachableDestinationAction {
        get => _unreachableDestinationAction;
        set {
            UnreachableDestinationActionSpecified = true;
            _unreachableDestinationAction = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationActionSpecified { get; set; }
    private string _unreachableDestinationForwardAddress;

    [XmlElement(ElementName = "unreachableDestinationForwardAddress", IsNullable = false, Namespace = "")]
    public string UnreachableDestinationForwardAddress {
        get => _unreachableDestinationForwardAddress;
        set {
            UnreachableDestinationForwardAddressSpecified = true;
            _unreachableDestinationForwardAddress = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationForwardAddressSpecified { get; set; }
    private string _unreachableDestinationRerouteTrunkGroupId;

    [XmlElement(ElementName = "unreachableDestinationRerouteTrunkGroupId", IsNullable = false, Namespace = "")]
    public string UnreachableDestinationRerouteTrunkGroupId {
        get => _unreachableDestinationRerouteTrunkGroupId;
        set {
            UnreachableDestinationRerouteTrunkGroupIdSpecified = true;
            _unreachableDestinationRerouteTrunkGroupId = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationRerouteTrunkGroupIdSpecified { get; set; }
    private int _unreachableDestinationTrapInitialCalls;

    [XmlElement(ElementName = "unreachableDestinationTrapInitialCalls", IsNullable = false, Namespace = "")]
    public int UnreachableDestinationTrapInitialCalls {
        get => _unreachableDestinationTrapInitialCalls;
        set {
            UnreachableDestinationTrapInitialCallsSpecified = true;
            _unreachableDestinationTrapInitialCalls = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationTrapInitialCallsSpecified { get; set; }
    private int _unreachableDestinationTrapOffsetCalls;

    [XmlElement(ElementName = "unreachableDestinationTrapOffsetCalls", IsNullable = false, Namespace = "")]
    public int UnreachableDestinationTrapOffsetCalls {
        get => _unreachableDestinationTrapOffsetCalls;
        set {
            UnreachableDestinationTrapOffsetCallsSpecified = true;
            _unreachableDestinationTrapOffsetCalls = value;
        }
    }

    [XmlIgnore]
    public bool UnreachableDestinationTrapOffsetCallsSpecified { get; set; }
    private int _invitationTimeout;

    [XmlElement(ElementName = "invitationTimeout", IsNullable = false, Namespace = "")]
    public int InvitationTimeout {
        get => _invitationTimeout;
        set {
            InvitationTimeoutSpecified = true;
            _invitationTimeout = value;
        }
    }

    [XmlIgnore]
    public bool InvitationTimeoutSpecified { get; set; }
    private bool _requireAuthentication;

    [XmlElement(ElementName = "requireAuthentication", IsNullable = false, Namespace = "")]
    public bool RequireAuthentication {
        get => _requireAuthentication;
        set {
            RequireAuthenticationSpecified = true;
            _requireAuthentication = value;
        }
    }

    [XmlIgnore]
    public bool RequireAuthenticationSpecified { get; set; }
    private string _sipAuthenticationUserName;

    [XmlElement(ElementName = "sipAuthenticationUserName", IsNullable = false, Namespace = "")]
    public string SipAuthenticationUserName {
        get => _sipAuthenticationUserName;
        set {
            SipAuthenticationUserNameSpecified = true;
            _sipAuthenticationUserName = value;
        }
    }

    [XmlIgnore]
    public bool SipAuthenticationUserNameSpecified { get; set; }
}
}
