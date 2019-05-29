using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingGetRadiusServerListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "radiusServerTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RadiusServerTable { get; set; }
 }
}
