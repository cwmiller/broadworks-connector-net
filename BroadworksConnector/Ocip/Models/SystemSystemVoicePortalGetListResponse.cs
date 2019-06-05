using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSystemVoicePortalGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _systemVoicePortalsTable;

    [XmlElement(ElementName = "systemVoicePortalsTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable SystemVoicePortalsTable {
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
