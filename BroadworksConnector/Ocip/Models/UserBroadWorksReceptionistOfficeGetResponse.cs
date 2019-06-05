using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksReceptionistOfficeGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _monitoredUserTable;

    [XmlElement(ElementName = "monitoredUserTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable MonitoredUserTable {
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
