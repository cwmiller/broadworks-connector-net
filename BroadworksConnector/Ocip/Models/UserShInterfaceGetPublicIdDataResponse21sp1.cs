using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserShInterfaceGetPublicIdDataResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "userType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserType UserType { get; set; }
    [XmlElement(ElementName = "endpointType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EndpointType21sp1 EndpointType { get; set; }
    [XmlElement(ElementName = "SCSCFName", IsNullable = false)]
    public string SCSCFName { get; set; }
    [XmlElement(ElementName = "IMSUserState", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.IMSUserState IMSUserState { get; set; }
 }
}
