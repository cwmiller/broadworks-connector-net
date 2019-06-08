using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkServerSyncParametersGetResponse14sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _enableSync;

    [XmlElement(ElementName = "enableSync", IsNullable = false, Namespace = "")]
    public bool EnableSync {
        get => _enableSync;
        set {
            EnableSyncSpecified = true;
            _enableSync = value;
        }
    }

    [XmlIgnore]
    public bool EnableSyncSpecified { get; set; }
    private bool _syncLinePorts;

    [XmlElement(ElementName = "syncLinePorts", IsNullable = false, Namespace = "")]
    public bool SyncLinePorts {
        get => _syncLinePorts;
        set {
            SyncLinePortsSpecified = true;
            _syncLinePorts = value;
        }
    }

    [XmlIgnore]
    public bool SyncLinePortsSpecified { get; set; }
}
}
