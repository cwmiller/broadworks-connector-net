using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClassmarkGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _classmarkTable;

    [XmlElement(ElementName = "classmarkTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable ClassmarkTable {
        get => _classmarkTable;
        set {
            ClassmarkTableSpecified = true;
            _classmarkTable = value;
        }
    }

    [XmlIgnore]
    public bool ClassmarkTableSpecified { get; set; }
}
}
