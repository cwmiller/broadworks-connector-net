using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementAutoRebuildConfigGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.C.OCITable _autoRebuildConfigTable;

    [XmlElement(ElementName = "autoRebuildConfigTable", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.C.OCITable AutoRebuildConfigTable {
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
