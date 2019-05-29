using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyAnnouncementRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    [XmlElement(ElementName = "onHoldMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementSelection OnHoldMessageSelection { get; set; }
    [XmlElement(ElementName = "onHoldMessageAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource OnHoldMessageAudioFile { get; set; }
    [XmlElement(ElementName = "onHoldMessageVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledFileResource OnHoldMessageVideoFile { get; set; }
 }
}
