using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementAutoRebuildConfigGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.C.OCITable _autoRebuildConfigTable;

    [XmlElement(ElementName = "autoRebuildConfigTable", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.C.OCITable AutoRebuildConfigTable {
        get => _autoRebuildConfigTable;
        set {
            AutoRebuildConfigTableSpecified = true;
            _autoRebuildConfigTable = value;
        }
    }

    [XmlIgnore]
    public bool AutoRebuildConfigTableSpecified { get; set; }
}
}
