using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkServerSyncParametersGetResponse14sp2 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableSync", IsNullable = false)]
    public bool EnableSync { get; set; }
    [XmlElement(ElementName = "syncLinePorts", IsNullable = false)]
    public bool SyncLinePorts { get; set; }
 }
}
