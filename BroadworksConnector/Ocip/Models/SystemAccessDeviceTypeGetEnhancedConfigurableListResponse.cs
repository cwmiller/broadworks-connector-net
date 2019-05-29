using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccessDeviceTypeGetEnhancedConfigurableListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deviceTypeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceTypeTable { get; set; }
 }
}
