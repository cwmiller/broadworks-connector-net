using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBusyLampFieldGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _listURI;

    [XmlElement(ElementName = "listURI", IsNullable = false, Namespace = "")]
    public string ListURI {
        get => _listURI;
        set {
            ListURISpecified = true;
            _listURI = value;
        }
    }

    [XmlIgnore]
    public bool ListURISpecified { get; set; }
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
