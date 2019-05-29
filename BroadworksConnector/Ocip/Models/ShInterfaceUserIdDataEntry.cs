using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ShInterfaceUserIdDataEntry 
{
    [XmlElement(ElementName = "userType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserType UserType { get; set; }
    [XmlElement(ElementName = "publicUserIdentity", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PublicUserIdentity PublicUserIdentity { get; set; }
    [XmlElement(ElementName = "endpointType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EndpointType EndpointType { get; set; }
    [XmlElement(ElementName = "SCSCFName", IsNullable = false)]
    public string SCSCFName { get; set; }
    [XmlElement(ElementName = "IMSUserState", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IMSUserState IMSUserState { get; set; }
 }
}
