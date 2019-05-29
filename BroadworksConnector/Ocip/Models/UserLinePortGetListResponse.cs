using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserLinePortGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "linePortTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable LinePortTable { get; set; }
 }
}
