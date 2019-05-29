using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceTypeCustomTagGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupDeviceTypeCustomTagsTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupDeviceTypeCustomTagsTable { get; set; }
 }
}
