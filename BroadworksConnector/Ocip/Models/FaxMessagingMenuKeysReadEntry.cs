using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class FaxMessagingMenuKeysReadEntry 
{
    [XmlElement(ElementName = "saveFaxMessageAndSkipToNext", IsNullable = false)]
    public string SaveFaxMessageAndSkipToNext { get; set; }
    [XmlElement(ElementName = "previousFaxMessage", IsNullable = false)]
    public string PreviousFaxMessage { get; set; }
    [XmlElement(ElementName = "playEnvelope", IsNullable = false)]
    public string PlayEnvelope { get; set; }
    [XmlElement(ElementName = "nextFaxMessage", IsNullable = false)]
    public string NextFaxMessage { get; set; }
    [XmlElement(ElementName = "deleteFaxMessage", IsNullable = false)]
    public string DeleteFaxMessage { get; set; }
    [XmlElement(ElementName = "printFaxMessage", IsNullable = false)]
    public string PrintFaxMessage { get; set; }
    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false)]
    public string ReturnToPreviousMenu { get; set; }
 }
}
