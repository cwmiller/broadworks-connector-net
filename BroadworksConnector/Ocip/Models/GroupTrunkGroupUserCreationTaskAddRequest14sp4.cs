using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupTrunkGroupUserCreationTaskAddRequest14sp4 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "trunkGroupKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TrunkGroupKey TrunkGroupKey { get; set; }
    [XmlElement(ElementName = "taskName", IsNullable = false)]
    public string TaskName { get; set; }
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
    [XmlElement(ElementName = "userPhoneNumbers", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserPhoneNumbers UserPhoneNumbers { get; set; }
    [XmlElement(ElementName = "userExtensions", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupTrunkGroupUserCreationTaskAddRequest14sp4UserExtensions UserExtensions { get; set; }
    [XmlElement(ElementName = "servicePackName", IsNullable = false)]
    public List<string> ServicePackName { get; set; }
    [XmlElement(ElementName = "userService", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.UserService> UserService { get; set; }
 }
}
