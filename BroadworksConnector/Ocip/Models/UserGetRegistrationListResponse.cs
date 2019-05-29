using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGetRegistrationListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "registrationTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable RegistrationTable { get; set; }
 }
}
