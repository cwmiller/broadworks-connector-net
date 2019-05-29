using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestCommPilotExpressProfileMenuKeys 
{
    [XmlElement(ElementName = "activateAvailableInOfficeProfile", IsNullable = true)]
    public string ActivateAvailableInOfficeProfile { get; set; }
    [XmlElement(ElementName = "activateAvailableOutOfOfficeProfile", IsNullable = true)]
    public string ActivateAvailableOutOfOfficeProfile { get; set; }
    [XmlElement(ElementName = "activateBusyProfile", IsNullable = true)]
    public string ActivateBusyProfile { get; set; }
    [XmlElement(ElementName = "activateUnavailableProfile", IsNullable = true)]
    public string ActivateUnavailableProfile { get; set; }
    [XmlElement(ElementName = "noProfile", IsNullable = true)]
    public string NoProfile { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
