using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAlternateUserIdGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "alternateUserIdTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AlternateUserIdTable { get; set; }
 }
}
