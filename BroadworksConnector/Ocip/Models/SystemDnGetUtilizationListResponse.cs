using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDnGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _dnUtilizationTable;

    [XmlElement(ElementName = "dnUtilizationTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable DnUtilizationTable {
        get => _dnUtilizationTable;
        set {
            DnUtilizationTableSpecified = true;
            _dnUtilizationTable = value;
        }
    }

    [XmlIgnore]
    public bool DnUtilizationTableSpecified { get; set; }
}
}
