using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVideoServerGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "videoServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable VideoServerTable { get; set; }
 }
}
