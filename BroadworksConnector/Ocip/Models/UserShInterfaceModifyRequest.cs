using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserShInterfaceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "publicUserIdentity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PublicUserIdentity PublicUserIdentity { get; set; }
    [XmlElement(ElementName = "SCSCFName", IsNullable = true)]
    public string SCSCFName { get; set; }
    [XmlElement(ElementName = "IMSUserState", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IMSUserState IMSUserState { get; set; }
 }
}
