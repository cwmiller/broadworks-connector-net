using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAccessDeviceTagsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deviceTagsTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable DeviceTagsTable { get; set; }
 }
}
