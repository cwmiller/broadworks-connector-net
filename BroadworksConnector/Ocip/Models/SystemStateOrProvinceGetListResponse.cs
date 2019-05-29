using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemStateOrProvinceGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "stateOrProvinceTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable StateOrProvinceTable { get; set; }
 }
}
