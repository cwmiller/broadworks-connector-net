using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceCodeGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "serviceCodeTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ServiceCodeTable { get; set; }
 }
}
