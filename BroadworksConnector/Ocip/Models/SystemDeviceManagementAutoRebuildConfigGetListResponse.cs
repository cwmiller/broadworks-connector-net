using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementAutoRebuildConfigGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "autoRebuildConfigTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AutoRebuildConfigTable { get; set; }
 }
}
