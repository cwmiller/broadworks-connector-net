using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskModifyUserSelectionRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "taskName", IsNullable = false)]
    public string TaskName { get; set; }
    [XmlElement(ElementName = "userSelectionType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServicePackMigrationTaskUserSelectionType UserSelectionType { get; set; }
    [XmlElement(ElementName = "userServiceNameList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementUserServiceList UserServiceNameList { get; set; }
    [XmlElement(ElementName = "servicePackNameList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ReplacementServicePackNameList ServicePackNameList { get; set; }
 }
}
