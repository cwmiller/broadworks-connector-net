using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAutomaticCollectCallGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false)]
    public bool EnableAutomaticCollectCall { get; set; }
 }
}
