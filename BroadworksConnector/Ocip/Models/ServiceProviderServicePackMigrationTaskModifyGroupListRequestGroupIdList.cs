using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderServicePackMigrationTaskModifyGroupListRequestGroupIdList 
{
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public List<string> GroupId { get; set; }
 }
}
