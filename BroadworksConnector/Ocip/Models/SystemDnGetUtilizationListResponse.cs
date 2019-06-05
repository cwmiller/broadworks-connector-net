using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDnGetUtilizationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _dnUtilizationTable;

    [XmlElement(ElementName = "dnUtilizationTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable DnUtilizationTable {
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
