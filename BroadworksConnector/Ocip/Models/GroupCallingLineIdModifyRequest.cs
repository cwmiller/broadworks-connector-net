using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallingLineIdModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "useGroupNumber", IsNullable = false)]
    public bool UseGroupNumber { get; set; }
    [XmlElement(ElementName = "useGroupName", IsNullable = false)]
    public bool UseGroupName { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true)]
    public string CallingLineIdPhoneNumber { get; set; }
 }
}
