using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCollaborateBridgeGetInstanceResponse20sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile {
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
    private bool _isDefault;

    [XmlElement(ElementName = "isDefault", IsNullable = false, Namespace = "")]
    public bool IsDefault {
        get => _isDefault;
        set {
            IsDefaultSpecified = true;
            _isDefault = value;
        }
    }

    [XmlIgnore]
    public bool IsDefaultSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.C.OCITable _collaborateOwnerUserTable;

    [XmlElement(ElementName = "collaborateOwnerUserTable", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CollaborateOwnerUserTable {
        get => _collaborateOwnerUserTable;
        set {
            CollaborateOwnerUserTableSpecified = true;
            _collaborateOwnerUserTable = value;
        }
    }

    [XmlIgnore]
    public bool CollaborateOwnerUserTableSpecified { get; set; }
}
}
