using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupAddInstanceRequest14 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ServiceInstanceAddProfileTrunkGroup _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceAddProfileTrunkGroup ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AccessDeviceEndpointAdd _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointAdd AccessDeviceEndpoint {
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
    private string _sipAuthenticationPassword;

    [XmlElement(ElementName = "sipAuthenticationPassword", IsNullable = false, Namespace = "")]
    public string SipAuthenticationPassword {
        get => _sipAuthenticationPassword;
        set {
            SipAuthenticationPasswordSpecified = true;
            _sipAuthenticationPassword = value;
        }
    }

    [XmlIgnore]
    public bool SipAuthenticationPasswordSpecified { get; set; }
}
}
