using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse14CommPilotExpressProfileMenuKeys 
{
    [XmlElement(ElementName = "activateAvailableInOfficeProfile", IsNullable = false)]
    public string ActivateAvailableInOfficeProfile { get; set; }
    [XmlElement(ElementName = "activateAvailableOutOfOfficeProfile", IsNullable = false)]
    public string ActivateAvailableOutOfOfficeProfile { get; set; }
    [XmlElement(ElementName = "activateBusyProfile", IsNullable = false)]
    public string ActivateBusyProfile { get; set; }
    [XmlElement(ElementName = "activateUnavailableProfile", IsNullable = false)]
    public string ActivateUnavailableProfile { get; set; }
    [XmlElement(ElementName = "noProfile", IsNullable = false)]
    public string NoProfile { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
