using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class LoginResponse13mp10 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "loginType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LoginType LoginType { get; set; }
    [XmlElement(ElementName = "locale", IsNullable = false)]
    public string Locale { get; set; }
    [XmlElement(ElementName = "encoding", IsNullable = false)]
    public string Encoding { get; set; }
 }
}
