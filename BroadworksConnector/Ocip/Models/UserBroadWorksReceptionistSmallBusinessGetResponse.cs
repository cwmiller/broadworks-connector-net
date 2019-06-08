using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistSmallBusinessGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

    [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable MonitoredUserTable {
        get => _monitoredUserTable;
        set {
            MonitoredUserTableSpecified = true;
            _monitoredUserTable = value;
        }
    }

    [XmlIgnore]
    public bool MonitoredUserTableSpecified { get; set; }
}
}
