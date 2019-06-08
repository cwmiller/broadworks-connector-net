using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallingPlanGetDigitPatternListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _digitPatternTable;

    [XmlElement(ElementName = "digitPatternTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DigitPatternTable {
        get => _digitPatternTable;
        set {
            DigitPatternTableSpecified = true;
            _digitPatternTable = value;
        }
    }

    [XmlIgnore]
    public bool DigitPatternTableSpecified { get; set; }
}
}
