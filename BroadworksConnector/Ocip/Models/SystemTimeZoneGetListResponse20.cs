using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTimeZoneGetListResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _serverTimeZone;

    [XmlElement(ElementName = "serverTimeZone", IsNullable = false, Namespace = "")]
    public string ServerTimeZone {
        get => _serverTimeZone;
        set {
            ServerTimeZoneSpecified = true;
            _serverTimeZone = value;
        }
    }

    [XmlIgnore]
    public bool ServerTimeZoneSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _timeZoneTable;

    [XmlElement(ElementName = "timeZoneTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable TimeZoneTable {
        get => _timeZoneTable;
        set {
            TimeZoneTableSpecified = true;
            _timeZoneTable = value;
        }
    }

    [XmlIgnore]
    public bool TimeZoneTableSpecified { get; set; }
}
}
