using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserExecutiveAssistantGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.C.OCITable _executiveTable;

    [XmlElement(ElementName = "executiveTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ExecutiveTable {
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
