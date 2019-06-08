using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCollaborateBridgeConsolidatedAddInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _addPhoneNumberToGroup;

    [XmlElement(ElementName = "addPhoneNumberToGroup", IsNullable = false, Namespace = "")]
    public bool AddPhoneNumberToGroup {
        get => _addPhoneNumberToGroup;
        set {
            AddPhoneNumberToGroupSpecified = true;
            _addPhoneNumberToGroup = value;
        }
    }

    [XmlIgnore]
    public bool AddPhoneNumberToGroupSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceInstanceAddProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants _maximumBridgeParticipants;

    [XmlElement(ElementName = "maximumBridgeParticipants", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants MaximumBridgeParticipants {
        get => _maximumBridgeParticipants;
        set {
            MaximumBridgeParticipantsSpecified = true;
            _maximumBridgeParticipants = value;
        }
    }

    [XmlIgnore]
    public bool MaximumBridgeParticipantsSpecified { get; set; }
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
    private List<string> _collaborateOwnerUserId;

    [XmlElement(ElementName = "collaborateOwnerUserId", IsNullable = false, Namespace = "")]
    public List<string> CollaborateOwnerUserId {
        get => _collaborateOwnerUserId;
        set {
            CollaborateOwnerUserIdSpecified = true;
            _collaborateOwnerUserId = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateOwnerUserIdSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> _service;

    [XmlElement(ElementName = "service", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ConsolidatedUserServiceAssignment> Service {
        get => _service;
        set {
            ServiceSpecified = true;
            _service = value;
        }
    }

    [XmlIgnore]
    public bool ServiceSpecified { get; set; }
}
}
