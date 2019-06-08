using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _totalNumberOfRows;

    [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false, Namespace = "")]
    public int TotalNumberOfRows {
        get => _totalNumberOfRows;
        set {
            TotalNumberOfRowsSpecified = true;
            _totalNumberOfRows = value;
        }
    }

    [XmlIgnore]
    public bool TotalNumberOfRowsSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> _callLog;

    [XmlElement(ElementName = "callLog", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.MixedCallLogsEntry> CallLog {
        get => _callLog;
        set {
            CallLogSpecified = true;
            _callLog = value;
        }
    }

    [XmlIgnore]
    public bool CallLogSpecified { get; set; }
}
}
