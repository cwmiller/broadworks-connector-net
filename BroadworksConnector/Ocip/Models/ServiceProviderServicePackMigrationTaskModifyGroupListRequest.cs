using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskModifyGroupListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "taskName", IsNullable = false)]
    public string TaskName { get; set; }
    [XmlElement(ElementName = "migrateAllGroups", IsNullable = false)]
    public bool MigrateAllGroups { get; set; }
    [XmlElement(ElementName = "groupIdList", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.ServiceProviderServicePackMigrationTaskModifyGroupListRequestGroupIdList GroupIdList { get; set; }
 }
}
