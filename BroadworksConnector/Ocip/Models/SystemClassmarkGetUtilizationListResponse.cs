using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClassmarkGetUtilizationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _classmarkUserTable;

    [XmlElement(ElementName = "classmarkUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ClassmarkUserTable {
        get => _classmarkUserTable;
        set {
            ClassmarkUserTableSpecified = true;
            _classmarkUserTable = value;
        }
    }

    [XmlIgnore]
    public bool ClassmarkUserTableSpecified { get; set; }
}
}
