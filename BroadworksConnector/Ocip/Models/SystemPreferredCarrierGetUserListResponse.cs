using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPreferredCarrierGetUserListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "usersUsingCarrierTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable UsersUsingCarrierTable { get; set; }
 }
}
