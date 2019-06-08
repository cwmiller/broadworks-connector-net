using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTimeZoneGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
