using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClassmarkGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _classmarkTable;

    [XmlElement(ElementName = "classmarkTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ClassmarkTable {
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