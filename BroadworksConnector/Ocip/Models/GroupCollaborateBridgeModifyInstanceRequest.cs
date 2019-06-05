using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCollaborateBridgeModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants _maximumBridgeParticipants;

    [XmlElement(ElementName = "maximumBridgeParticipants", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CollaborateBridgeMaximumParticipants MaximumBridgeParticipants {
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
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _collaborateOwnerUserIdList;

    [XmlElement(ElementName = "collaborateOwnerUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList CollaborateOwnerUserIdList {
        get => _collaborateOwnerUserIdList;
        set {
            CollaborateOwnerUserIdListSpecified = true;
            _collaborateOwnerUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateOwnerUserIdListSpecified { get; set; }
}
}
