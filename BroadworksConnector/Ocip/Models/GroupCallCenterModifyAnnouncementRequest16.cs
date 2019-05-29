using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyAnnouncementRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "playEntranceMessage", IsNullable = false)]
    public bool PlayEntranceMessage { get; set; }
    [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false)]
    public bool MandatoryEntranceMessage { get; set; }
    [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceMessageAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource EntranceMessageAudioFile { get; set; }
    [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceMessageVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource EntranceMessageVideoFile { get; set; }
    [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false)]
    public bool PlayPeriodicComfortMessage { get; set; }
    [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false)]
    public int TimeBetweenComfortMessagesSeconds { get; set; }
    [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource PeriodicComfortMessageAudioFile { get; set; }
    [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource PeriodicComfortMessageVideoFile { get; set; }
    [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false)]
    public bool EnableMediaOnHoldForQueuedCalls { get; set; }
    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 MediaOnHoldSource { get; set; }
    [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false)]
    public bool MediaOnHoldUseAlternateSourceForInternalCalls { get; set; }
    [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify16 MediaOnHoldInternalSource { get; set; }
 }
}
