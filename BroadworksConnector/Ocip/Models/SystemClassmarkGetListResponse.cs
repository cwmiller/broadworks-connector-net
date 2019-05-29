using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClassmarkGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "classmarkTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ClassmarkTable { get; set; }
 }
}
