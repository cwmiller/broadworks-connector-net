using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetAnnouncementResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "entranceMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementSelection EntranceMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceMessageAudioFileDescription", IsNullable = false)]
    public string EntranceMessageAudioFileDescription { get; set; }
    [XmlElement(ElementName = "entranceMessageVideoFileDescription", IsNullable = false)]
    public string EntranceMessageVideoFileDescription { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementSelection PeriodicComfortMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageAudioFileDescription", IsNullable = false)]
    public string PeriodicComfortMessageAudioFileDescription { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageVideoFileDescription", IsNullable = false)]
    public string PeriodicComfortMessageVideoFileDescription { get; set; }
    [XmlElement(ElementName = "onHoldMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementSelection OnHoldMessageSelection { get; set; }
    [XmlElement(ElementName = "onHoldMessageAudioFileDescription", IsNullable = false)]
    public string OnHoldMessageAudioFileDescription { get; set; }
    [XmlElement(ElementName = "onHoldMessageVideoFileDescription", IsNullable = false)]
    public string OnHoldMessageVideoFileDescription { get; set; }
 }
}
