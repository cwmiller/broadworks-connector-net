using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFeatureAccessCodeModifyRequest21 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "useFeatureAccessCodeLevel", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupFeatureAccessCodeLevel UseFeatureAccessCodeLevel { get; set; }
    [XmlElement(ElementName = "restoreDefaultCodes", IsNullable = false)]
    public bool RestoreDefaultCodes { get; set; }
    [XmlElement(ElementName = "featureAccessCode", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.FeatureAccessCodeModifyEntry> FeatureAccessCode { get; set; }
 }
}
