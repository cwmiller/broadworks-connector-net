using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingPartyCategoryGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _callingPartyCategoryTable;

    [XmlElement(ElementName = "callingPartyCategoryTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CallingPartyCategoryTable {
        get => _callingPartyCategoryTable;
        set {
            CallingPartyCategoryTableSpecified = true;
            _callingPartyCategoryTable = value;
        }
    }

    [XmlIgnore]
    public bool CallingPartyCategoryTableSpecified { get; set; }
}
}
