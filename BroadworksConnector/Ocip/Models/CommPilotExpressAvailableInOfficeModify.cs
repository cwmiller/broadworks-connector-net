using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CommPilotExpressAvailableInOfficeModify 
{
    private string _additionalPhoneNumberToRing;

    [XmlElement(ElementName = "additionalPhoneNumberToRing", IsNullable = true, Namespace = "")]
    public string AdditionalPhoneNumberToRing {
        get => _additionalPhoneNumberToRing;
        set {
            AdditionalPhoneNumberToRingSpecified = true;
            _additionalPhoneNumberToRing = value;
        }
    }

    [XmlIgnore]
    public bool AdditionalPhoneNumberToRingSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify _busySetting;

    [XmlElement(ElementName = "busySetting", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify BusySetting {
        get => _busySetting;
        set {
            BusySettingSpecified = true;
            _busySetting = value;
        }
    }

    [XmlIgnore]
    public bool BusySettingSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify _noAnswerSetting;

    [XmlElement(ElementName = "noAnswerSetting", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommPilotExpressRedirectionModify NoAnswerSetting {
        get => _noAnswerSetting;
        set {
            NoAnswerSettingSpecified = true;
            _noAnswerSetting = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerSettingSpecified { get; set; }
}
}
