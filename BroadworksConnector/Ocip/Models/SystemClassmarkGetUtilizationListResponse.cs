using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClassmarkGetUtilizationListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _classmarkUserTable;

    [XmlElement(ElementName = "classmarkUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable ClassmarkUserTable {
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
