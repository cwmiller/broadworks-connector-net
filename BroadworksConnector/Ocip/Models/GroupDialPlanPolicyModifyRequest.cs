using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupDialPlanPolicyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "useSetting", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDialPlanPolicySettingLevel UseSetting { get; set; }
    [XmlElement(ElementName = "requiresAccessCodeForPublicCalls", IsNullable = false)]
    public bool RequiresAccessCodeForPublicCalls { get; set; }
    [XmlElement(ElementName = "allowE164PublicCalls", IsNullable = false)]
    public bool AllowE164PublicCalls { get; set; }
    [XmlElement(ElementName = "preferE164NumberFormatForCallbackServices", IsNullable = false)]
    public bool PreferE164NumberFormatForCallbackServices { get; set; }
    [XmlElement(ElementName = "publicDigitMap", IsNullable = true)]
    public string PublicDigitMap { get; set; }
    [XmlElement(ElementName = "privateDigitMap", IsNullable = true)]
    public string PrivateDigitMap { get; set; }
 }
}
