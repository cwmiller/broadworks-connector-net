using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetAnnouncementResponse14sp6 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    [XmlElement(ElementName = "onHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead OnHoldSource { get; set; }
    [XmlElement(ElementName = "onHoldUseAlternateSourceForInternalCalls", IsNullable = false)]
    public bool OnHoldUseAlternateSourceForInternalCalls { get; set; }
    [XmlElement(ElementName = "onHoldInternalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMusicOnHoldSourceRead OnHoldInternalSource { get; set; }
 }
}
