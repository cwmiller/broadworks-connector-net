using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupUserCreationTaskGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "userIdFormat", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUserCreationUserIdFormat UserIdFormat { get; set; }
    [XmlElement(ElementName = "userIdDomain", IsNullable = false)]
    public string UserIdDomain { get; set; }
    [XmlElement(ElementName = "populateExtension", IsNullable = false)]
    public bool PopulateExtension { get; set; }
    [XmlElement(ElementName = "linePortFormat", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat LinePortFormat { get; set; }
    [XmlElement(ElementName = "linePortDomain", IsNullable = false)]
    public string LinePortDomain { get; set; }
    [XmlElement(ElementName = "populateContact", IsNullable = false)]
    public bool PopulateContact { get; set; }
    [XmlElement(ElementName = "contactFormat", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUserCreationSIPURIFormat ContactFormat { get; set; }
    [XmlElement(ElementName = "contactDomain", IsNullable = false)]
    public string ContactDomain { get; set; }
    [XmlElement(ElementName = "usersCreated", IsNullable = false)]
    public int UsersCreated { get; set; }
    [XmlElement(ElementName = "totalUsersToCreate", IsNullable = false)]
    public int TotalUsersToCreate { get; set; }
    [XmlElement(ElementName = "errorCount", IsNullable = false)]
    public int ErrorCount { get; set; }
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public List<string> ServicePackName { get; set; }
    [XmlElement(ElementName = "userServiceName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserService> UserServiceName { get; set; }
    [XmlElement(ElementName = "status", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUserCreationTaskStatus Status { get; set; }
    [XmlElement(ElementName = "userCreationMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupUserCreationMode UserCreationMode { get; set; }
    [XmlElement(ElementName = "taskSummary", IsNullable = false)]
    public string TaskSummary { get; set; }
 }
}
