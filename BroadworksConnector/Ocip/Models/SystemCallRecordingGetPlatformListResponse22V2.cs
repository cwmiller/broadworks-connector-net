using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallRecordingGetPlatformListResponse22V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _systemDefault;

    [XmlElement(ElementName = "systemDefault", IsNullable = false, Namespace = "")]
    public string SystemDefault {
        get => _systemDefault;
        set {
            SystemDefaultSpecified = true;
            _systemDefault = value;
        }
    }

    [XmlIgnore]
    public bool SystemDefaultSpecified { get; set; }
    private string _resellerDefault;

    [XmlElement(ElementName = "resellerDefault", IsNullable = false, Namespace = "")]
    public string ResellerDefault {
        get => _resellerDefault;
        set {
            ResellerDefaultSpecified = true;
            _resellerDefault = value;
        }
    }

    [XmlIgnore]
    public bool ResellerDefaultSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.C.OCITable _callRecordingPlatformTable;

    [XmlElement(ElementName = "callRecordingPlatformTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable CallRecordingPlatformTable {
        get => _callRecordingPlatformTable;
        set {
            CallRecordingPlatformTableSpecified = true;
            _callRecordingPlatformTable = value;
        }
    }

    [XmlIgnore]
    public bool CallRecordingPlatformTableSpecified { get; set; }
}
}
