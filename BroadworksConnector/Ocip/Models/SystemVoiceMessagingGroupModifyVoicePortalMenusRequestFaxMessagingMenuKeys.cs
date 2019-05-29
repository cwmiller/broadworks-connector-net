using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequestFaxMessagingMenuKeys 
{
    [XmlElement(ElementName = "saveFaxMessageAndSkipToNext", IsNullable = true)]
    public string SaveFaxMessageAndSkipToNext { get; set; }
    [XmlElement(ElementName = "previousFaxMessage", IsNullable = true)]
    public string PreviousFaxMessage { get; set; }
    [XmlElement(ElementName = "playEnvelope", IsNullable = true)]
    public string PlayEnvelope { get; set; }
    [XmlElement(ElementName = "nextFaxMessage", IsNullable = true)]
    public string NextFaxMessage { get; set; }
    [XmlElement(ElementName = "deleteFaxMessage", IsNullable = true)]
    public string DeleteFaxMessage { get; set; }
    [XmlElement(ElementName = "printFaxMessage", IsNullable = true)]
    public string PrintFaxMessage { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = true)]
    public string ReturnToPreviousMenu { get; set; }
 }
}
