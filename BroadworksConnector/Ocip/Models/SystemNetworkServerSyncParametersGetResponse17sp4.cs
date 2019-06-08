using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkServerSyncParametersGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private bool _syncDeviceManagementInfo;

    [XmlElement(ElementName = "syncDeviceManagementInfo", IsNullable = false, Namespace = "")]
    public bool SyncDeviceManagementInfo {
        get => _syncDeviceManagementInfo;
        set {
            SyncDeviceManagementInfoSpecified = true;
            _syncDeviceManagementInfo = value;
        }
    }

    [XmlIgnore]
    public bool SyncDeviceManagementInfoSpecified { get; set; }
    private bool _syncTrunkGroups;

    [XmlElement(ElementName = "syncTrunkGroups", IsNullable = false, Namespace = "")]
    public bool SyncTrunkGroups {
        get => _syncTrunkGroups;
        set {
            SyncTrunkGroupsSpecified = true;
            _syncTrunkGroups = value;
        }
    }

    [XmlIgnore]
    public bool SyncTrunkGroupsSpecified { get; set; }
}
}
