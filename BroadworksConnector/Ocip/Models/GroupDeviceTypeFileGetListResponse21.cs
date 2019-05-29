using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDeviceTypeFileGetListResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupDeviceTypeFilesTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable GroupDeviceTypeFilesTable { get; set; }
    [XmlElement(ElementName = "groupHasCustomizableDynamicFiles", IsNullable = false)]
    public bool GroupHasCustomizableDynamicFiles { get; set; }
 }
}
