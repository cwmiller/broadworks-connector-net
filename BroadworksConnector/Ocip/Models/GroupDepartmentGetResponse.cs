using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "parentDepartmentKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DepartmentKey ParentDepartmentKey { get; set; }
    [XmlElement(ElementName = "callingLineIdName", IsNullable = false)]
    public string CallingLineIdName { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = false)]
    public string CallingLineIdPhoneNumber { get; set; }
 }
}
