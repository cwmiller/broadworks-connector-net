using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCommPilotExpressGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.CommPilotExpressProfile _profile;

    [XmlElement(ElementName = "profile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressProfile Profile {
        get => _profile;
        set {
            ProfileSpecified = true;
            _profile = value;
        }
    }

    [XmlIgnore]
    public bool ProfileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableInOffice _availableInOffice;

    [XmlElement(ElementName = "availableInOffice", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableInOffice AvailableInOffice {
        get => _availableInOffice;
        set {
            AvailableInOfficeSpecified = true;
            _availableInOffice = value;
        }
    }

    [XmlIgnore]
    public bool AvailableInOfficeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOffice _availableOutOfOffice;

    [XmlElement(ElementName = "availableOutOfOffice", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressAvailableOutOfOffice AvailableOutOfOffice {
        get => _availableOutOfOffice;
        set {
            AvailableOutOfOfficeSpecified = true;
            _availableOutOfOffice = value;
        }
    }

    [XmlIgnore]
    public bool AvailableOutOfOfficeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressBusy _busy;

    [XmlElement(ElementName = "busy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressBusy Busy {
        get => _busy;
        set {
            BusySpecified = true;
            _busy = value;
        }
    }

    [XmlIgnore]
    public bool BusySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressUnavailable _unavailable;

    [XmlElement(ElementName = "unavailable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressUnavailable Unavailable {
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
