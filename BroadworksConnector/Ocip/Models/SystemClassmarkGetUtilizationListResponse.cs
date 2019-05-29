using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemClassmarkGetUtilizationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "classmarkUserTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable ClassmarkUserTable { get; set; }
 }
}
