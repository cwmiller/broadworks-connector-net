using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _statusDigitPatternTable;

    [XmlElement(ElementName = "statusDigitPatternTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable StatusDigitPatternTable {
        get => _statusDigitPatternTable;
        set {
            StatusDigitPatternTableSpecified = true;
            _statusDigitPatternTable = value;
        }
    }

    [XmlIgnore]
    public bool StatusDigitPatternTableSpecified { get; set; }
}
}
