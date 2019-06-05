using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDiversionReasonGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _diversionReasonTable;

    [XmlElement(ElementName = "diversionReasonTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DiversionReasonTable {
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
