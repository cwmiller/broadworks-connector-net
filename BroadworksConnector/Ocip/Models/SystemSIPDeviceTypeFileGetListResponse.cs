using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeFileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deviceTypeFilesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceTypeFilesTable { get; set; }
 }
}
