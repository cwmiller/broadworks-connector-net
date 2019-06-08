using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemExpensiveCallTypeGetListResponse16sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _alternateCallIndicatorTable;

    [XmlElement(ElementName = "alternateCallIndicatorTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AlternateCallIndicatorTable {
        get => _alternateCallIndicatorTable;
        set {
            AlternateCallIndicatorTableSpecified = true;
            _alternateCallIndicatorTable = value;
        }
    }

    [XmlIgnore]
    public bool AlternateCallIndicatorTableSpecified { get; set; }
}
}
