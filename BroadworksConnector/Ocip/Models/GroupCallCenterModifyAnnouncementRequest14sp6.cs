using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyAnnouncementRequest14sp6 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "entranceMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementSelection EntranceMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceMessageAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource EntranceMessageAudioFile { get; set; }
    [XmlElement(ElementName = "entranceMessageVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource EntranceMessageVideoFile { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementSelection PeriodicComfortMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource PeriodicComfortMessageAudioFile { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource PeriodicComfortMessageVideoFile { get; set; }
    [XmlElement(ElementName = "onHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMusicOnHoldSourceModify OnHoldSource { get; set; }
    [XmlElement(ElementName = "onHoldUseAlternateSourceForInternalCalls", IsNullable = false)]
    public bool OnHoldUseAlternateSourceForInternalCalls { get; set; }
    [XmlElement(ElementName = "onHoldInternalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMusicOnHoldSourceModify OnHoldInternalSource { get; set; }
 }
}
