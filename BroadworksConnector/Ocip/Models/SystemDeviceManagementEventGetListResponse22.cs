using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementEventGetListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "eventTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable EventTable { get; set; }
 }
}
