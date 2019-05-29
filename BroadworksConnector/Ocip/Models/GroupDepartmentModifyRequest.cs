using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDepartmentModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "departmentName", IsNullable = false)]
    public string DepartmentName { get; set; }
    [XmlElement(ElementName = "newDepartmentName", IsNullable = false)]
    public string NewDepartmentName { get; set; }
    [XmlElement(ElementName = "newParentDepartmentKey", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.DepartmentKey NewParentDepartmentKey { get; set; }
    [XmlElement(ElementName = "callingLineIdName", IsNullable = true)]
    public string CallingLineIdName { get; set; }
    [XmlElement(ElementName = "callingLineIdPhoneNumber", IsNullable = true)]
    public string CallingLineIdPhoneNumber { get; set; }
 }
}
