using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceFileGetListResponse14sp8 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deviceFilesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceFilesTable { get; set; }
 }
}
