using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceTypeFileGetListResponse14sp8 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupDeviceTypeFilesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupDeviceTypeFilesTable { get; set; }
 }
}
