using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "mediaServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable MediaServerTable { get; set; }
 }
}
