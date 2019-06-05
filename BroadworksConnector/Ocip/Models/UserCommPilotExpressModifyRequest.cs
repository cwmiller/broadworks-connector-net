using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommPilotExpressModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.CommPilotExpressProfile? _profile;

    [XmlElement(ElementName = "profile", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressProfile? Profile {
        get => _profile;
        set {
            ProfileSpecified = true;
            _profile = value;
        }
    }

    [XmlIgnore]
    public bool ProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommPilotExpressAvailableInOfficeModify _availableInOffice;

    [XmlElement(ElementName = "availableInOffice", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressAvailableInOfficeModify AvailableInOffice {
        get => _availableInOffice;
        set {
            AvailableInOfficeSpecified = true;
            _availableInOffice = value;
        }
    }

    [XmlIgnore]
    public bool AvailableInOfficeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOfficeModify _availableOutOfOffice;

    [XmlElement(ElementName = "availableOutOfOffice", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOfficeModify AvailableOutOfOffice {
        get => _availableOutOfOffice;
        set {
            AvailableOutOfOfficeSpecified = true;
            _availableOutOfOffice = value;
        }
    }

    [XmlIgnore]
    public bool AvailableOutOfOfficeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommPilotExpressBusyModify _busy;

    [XmlElement(ElementName = "busy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressBusyModify Busy {
        get => _busy;
        set {
            BusySpecified = true;
            _busy = value;
        }
    }

    [XmlIgnore]
    public bool BusySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommPilotExpressUnavailableModify _unavailable;

    [XmlElement(ElementName = "unavailable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressUnavailableModify Unavailable {
        get => _unavailable;
        set {
            UnavailableSpecified = true;
            _unavailable = value;
        }
    }

    [XmlIgnore]
    public bool UnavailableSpecified { get; set; }
}
}
