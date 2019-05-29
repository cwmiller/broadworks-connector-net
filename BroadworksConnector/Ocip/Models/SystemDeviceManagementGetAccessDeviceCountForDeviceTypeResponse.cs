using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceManagementGetAccessDeviceCountForDeviceTypeResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "accessDeviceCount", IsNullable = false)]
    public int AccessDeviceCount { get; set; }
 }
}
