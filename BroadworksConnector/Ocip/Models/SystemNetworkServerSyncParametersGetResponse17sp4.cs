using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkServerSyncParametersGetResponse17sp4 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableSync", IsNullable = false)]
    public bool EnableSync { get; set; }
    [XmlElement(ElementName = "syncLinePorts", IsNullable = false)]
    public bool SyncLinePorts { get; set; }
    [XmlElement(ElementName = "syncDeviceManagementInfo", IsNullable = false)]
    public bool SyncDeviceManagementInfo { get; set; }
    [XmlElement(ElementName = "syncTrunkGroups", IsNullable = false)]
    public bool SyncTrunkGroups { get; set; }
 }
}
