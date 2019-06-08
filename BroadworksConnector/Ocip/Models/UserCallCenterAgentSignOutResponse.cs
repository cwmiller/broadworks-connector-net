using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterAgentSignOutResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _callCenterTable;

    [XmlElement(ElementName = "callCenterTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CallCenterTable {
        get => _callCenterTable;
        set {
            CallCenterTableSpecified = true;
            _callCenterTable = value;
        }
    }

    [XmlIgnore]
    public bool CallCenterTableSpecified { get; set; }
}
}
