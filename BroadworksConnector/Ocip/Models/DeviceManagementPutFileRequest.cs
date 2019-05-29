using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class DeviceManagementPutFileRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "deviceAccessURI", IsNullable = false)]
    public string DeviceAccessURI { get; set; }
    [XmlElement(ElementName = "ipAddress", IsNullable = false)]
    public string IpAddress { get; set; }
 }
}
