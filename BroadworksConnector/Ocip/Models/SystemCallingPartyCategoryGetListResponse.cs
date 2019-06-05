using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingPartyCategoryGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _callingPartyCategoryTable;

    [XmlElement(ElementName = "callingPartyCategoryTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable CallingPartyCategoryTable {
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
