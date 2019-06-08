using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterAgentUnavailableCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _unavailableCodesTable;

    [XmlElement(ElementName = "unavailableCodesTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable UnavailableCodesTable {
        get => _unavailableCodesTable;
        set {
            UnavailableCodesTableSpecified = true;
            _unavailableCodesTable = value;
        }
    }

    [XmlIgnore]
    public bool UnavailableCodesTableSpecified { get; set; }
}
}
