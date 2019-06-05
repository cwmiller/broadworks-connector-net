using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTimeZoneGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _timeZoneTable;

    [XmlElement(ElementName = "timeZoneTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable TimeZoneTable {
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
