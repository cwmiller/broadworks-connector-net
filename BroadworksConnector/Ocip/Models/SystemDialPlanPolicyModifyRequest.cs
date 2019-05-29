using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDialPlanPolicyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "requiresAccessCodeForPublicCalls", IsNullable = false)]
    public bool RequiresAccessCodeForPublicCalls { get; set; }
    [XmlElement(ElementName = "allowE164PublicCalls", IsNullable = false)]
    public bool AllowE164PublicCalls { get; set; }
    [XmlElement(ElementName = "preferE164NumberFormatForCallbackServices", IsNullable = false)]
    public bool PreferE164NumberFormatForCallbackServices { get; set; }
    [XmlElement(ElementName = "publicDigitMap", IsNullable = false)]
    public string PublicDigitMap { get; set; }
    [XmlElement(ElementName = "privateDigitMap", IsNullable = true)]
    public string PrivateDigitMap { get; set; }
 }
}
