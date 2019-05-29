using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAdminModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "firstName", IsNullable = true)]
    public string FirstName { get; set; }
    [XmlElement(ElementName = "lastName", IsNullable = true)]
    public string LastName { get; set; }
    [XmlElement(ElementName = "password", IsNullable = true)]
    public string Password { get; set; }
    [XmlElement(ElementName = "language", IsNullable = false)]
    public string Language { get; set; }
 }
}
