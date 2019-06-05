using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommPilotExpressGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.CommPilotExpressProfile _profile;

    [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressProfile Profile {
        get => _profile;
        set {
            ProfileSpecified = true;
            _profile = value;
        }
    }

    [XmlIgnore]
    public bool ProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommPilotExpressAvailableInOffice _availableInOffice;

    [XmlElement(ElementName = "availableInOffice", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressAvailableInOffice AvailableInOffice {
        get => _availableInOffice;
        set {
            AvailableInOfficeSpecified = true;
            _availableInOffice = value;
        }
    }

    [XmlIgnore]
    public bool AvailableInOfficeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOffice _availableOutOfOffice;

    [XmlElement(ElementName = "availableOutOfOffice", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOffice AvailableOutOfOffice {
        get => _availableOutOfOffice;
        set {
            AvailableOutOfOfficeSpecified = true;
            _availableOutOfOffice = value;
        }
    }

    [XmlIgnore]
    public bool AvailableOutOfOfficeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommPilotExpressBusy _busy;

    [XmlElement(ElementName = "busy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressBusy Busy {
        get => _busy;
        set {
            BusySpecified = true;
            _busy = value;
        }
    }

    [XmlIgnore]
    public bool BusySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CommPilotExpressUnavailable _unavailable;

    [XmlElement(ElementName = "unavailable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CommPilotExpressUnavailable Unavailable {
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
