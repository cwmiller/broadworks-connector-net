using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemVoicePortalGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _systemVoicePortalsTable;

    [XmlElement(ElementName = "systemVoicePortalsTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable SystemVoicePortalsTable {
        get => _systemVoicePortalsTable;
        set {
            SystemVoicePortalsTableSpecified = true;
            _systemVoicePortalsTable = value;
        }
    }

    [XmlIgnore]
    public bool SystemVoicePortalsTableSpecified { get; set; }
}
}