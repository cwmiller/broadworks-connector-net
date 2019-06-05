using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCollaborateBridgeGetResponse20sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private string _bridgeName;

    [XmlElement(ElementName = "bridgeName", IsNullable = false, Namespace = "")]
    public string BridgeName {
        get => _bridgeName;
        set {
            BridgeNameSpecified = true;
            _bridgeName = value;
        }
    }

    [XmlIgnore]
    public bool BridgeNameSpecified { get; set; }
    private string _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
    private string _extension;

    [XmlElement(ElementName = "extension", IsNullable = false, Namespace = "")]
    public string Extension {
        get => _extension;
        set {
            ExtensionSpecified = true;
            _extension = value;
        }
    }

    [XmlIgnore]
    public bool ExtensionSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.AlternateNumberEntry21> _alternateNumberEntry;

    [XmlElement(ElementName = "alternateNumberEntry", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.AlternateNumberEntry21> AlternateNumberEntry {
        get => _alternateNumberEntry;
        set {
            AlternateNumberEntrySpecified = true;
            _alternateNumberEntry = value;
        }
    }

    [XmlIgnore]
    public bool AlternateNumberEntrySpecified { get; set; }
    private bool _supportOutDial;

    [XmlElement(ElementName = "supportOutDial", IsNullable = false, Namespace = "")]
    public bool SupportOutDial {
        get => _supportOutDial;
        set {
            SupportOutDialSpecified = true;
            _supportOutDial = value;
        }
    }

    [XmlIgnore]
    public bool SupportOutDialSpecified { get; set; }
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
}
}
