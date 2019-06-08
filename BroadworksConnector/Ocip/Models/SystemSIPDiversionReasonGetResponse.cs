using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDiversionReasonGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _diversionReasonTable;

    [XmlElement(ElementName = "diversionReasonTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DiversionReasonTable {
        get => _diversionReasonTable;
        set {
            DiversionReasonTableSpecified = true;
            _diversionReasonTable = value;
        }
    }

    [XmlIgnore]
    public bool DiversionReasonTableSpecified { get; set; }
}
}
