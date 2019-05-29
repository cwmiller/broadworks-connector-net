using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class PersonalizedNameMenuKeysReadEntry 
{
    [XmlElement(ElementName = "recordNewPersonalizedName", IsNullable = false)]
    public string RecordNewPersonalizedName { get; set; }
    [XmlElement(ElementName = "listenToCurrentPersonalizedName", IsNullable = false)]
    public string ListenToCurrentPersonalizedName { get; set; }
    [XmlElement(ElementName = "deletePersonalizedName", IsNullable = false)]
    public string DeletePersonalizedName { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
    [XmlElement(ElementName = "repeatMenu", IsNullable = false)]
    public string RepeatMenu { get; set; }
 }
}
