using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveAssistantGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableDivert;

    [XmlElement(ElementName = "enableDivert", IsNullable = false, Namespace = "")]
    public bool EnableDivert {
        get => _enableDivert;
        set {
            EnableDivertSpecified = true;
            _enableDivert = value;
        }
    }

    [XmlIgnore]
    public bool EnableDivertSpecified { get; set; }
    private string _divertToPhoneNumber;

    [XmlElement(ElementName = "divertToPhoneNumber", IsNullable = false, Namespace = "")]
    public string DivertToPhoneNumber {
        get => _divertToPhoneNumber;
        set {
            DivertToPhoneNumberSpecified = true;
            _divertToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool DivertToPhoneNumberSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _executiveTable;

    [XmlElement(ElementName = "executiveTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ExecutiveTable {
        get => _executiveTable;
        set {
            ExecutiveTableSpecified = true;
            _executiveTable = value;
        }
    }

    [XmlIgnore]
    public bool ExecutiveTableSpecified { get; set; }
}
}
