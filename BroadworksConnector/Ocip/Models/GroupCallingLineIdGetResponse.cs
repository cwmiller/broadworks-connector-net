using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallingLineIdGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useGroupNumber", IsNullable = false)]
    public bool UseGroupNumber { get; set; }
    [XmlElement(ElementName = "useGroupName", IsNullable = false)]
    public bool UseGroupName { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false)]
    public string CallingLineIdPhoneNumber { get; set; }
    [XmlElement(ElementName = "callingLineIdName", IsNullable = false)]
    public string CallingLineIdName { get; set; }
 }
}
