using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19PersonalizedNameMenuKeys 
{
    [XmlElement(ElementName = "recordNewPersonalizedName", IsNullable = true)]
    public string RecordNewPersonalizedName { get; set; }
    [XmlElement(ElementName = "listenToCurrentPersonalizedName", IsNullable = true)]
    public string ListenToCurrentPersonalizedName { get; set; }
    [XmlElement(ElementName = "deletePersonalizedName", IsNullable = true)]
    public string DeletePersonalizedName { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = true)]
    public string RepeatMenu { get; set; }
 }
}
