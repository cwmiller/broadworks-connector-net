using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPDeviceTypeLanguageMappingGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deviceTypeLanguagesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceTypeLanguagesTable { get; set; }
 }
}
