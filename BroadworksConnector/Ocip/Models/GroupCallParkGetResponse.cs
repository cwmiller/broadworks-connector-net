using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallParkGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "recallTimerSeconds", IsNullable = false)]
    public int RecallTimerSeconds { get; set; }
    [XmlElement(ElementName = "displayTimerSeconds", IsNullable = false)]
    public int DisplayTimerSeconds { get; set; }
    [XmlElement(ElementName = "enableDestinationAnnouncement", IsNullable = false)]
    public bool EnableDestinationAnnouncement { get; set; }
 }
}
