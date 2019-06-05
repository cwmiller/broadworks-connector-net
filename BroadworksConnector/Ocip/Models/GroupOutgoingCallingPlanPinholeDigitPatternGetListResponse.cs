using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupOutgoingCallingPlanPinholeDigitPatternGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _digitPatternTable;

    [XmlElement(ElementName = "digitPatternTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DigitPatternTable {
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
