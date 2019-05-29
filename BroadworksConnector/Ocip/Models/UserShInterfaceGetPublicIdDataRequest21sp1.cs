using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserShInterfaceGetPublicIdDataRequest21sp1 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "publicUserIdentity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PublicUserIdentity PublicUserIdentity { get; set; }
 }
}
