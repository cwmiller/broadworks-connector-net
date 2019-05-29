using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupInventoryReportGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "includeUsers", IsNullable = false)]
    public bool IncludeUsers { get; set; }
    [XmlElement(ElementName = "includeServices", IsNullable = false)]
    public bool IncludeServices { get; set; }
    [XmlElement(ElementName = "includeDns", IsNullable = false)]
    public bool IncludeDns { get; set; }
    [XmlElement(ElementName = "includeAccessDevices", IsNullable = false)]
    public bool IncludeAccessDevices { get; set; }
    [XmlElement(ElementName = "includeDepartments", IsNullable = false)]
    public bool IncludeDepartments { get; set; }
    [XmlElement(ElementName = "reportDeliveryEmailAddress", IsNullable = false)]
    public string ReportDeliveryEmailAddress { get; set; }
 }
}
