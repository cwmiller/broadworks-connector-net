using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyDNISAnnouncementRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "dnisKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.DNISKey DnisKey { get; set; }
    [XmlElement(ElementName = "playEntranceMessage", IsNullable = false)]
    public bool PlayEntranceMessage { get; set; }
    [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false)]
    public bool MandatoryEntranceMessage { get; set; }
    [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceMessageAudioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify EntranceMessageAudioUrlList { get; set; }
    [XmlElement(ElementName = "entranceMessageAudioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify EntranceMessageAudioFileList { get; set; }
    [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceMessageVideoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify EntranceMessageVideoUrlList { get; set; }
    [XmlElement(ElementName = "entranceMessageVideoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify EntranceMessageVideoFileList { get; set; }
    [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false)]
    public bool PlayPeriodicComfortMessage { get; set; }
    [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false)]
    public int TimeBetweenComfortMessagesSeconds { get; set; }
    [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageAudioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify PeriodicComfortMessageAudioUrlList { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageAudioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify PeriodicComfortMessageAudioFileList { get; set; }
    [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageVideoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify PeriodicComfortMessageVideoUrlList { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageVideoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify PeriodicComfortMessageVideoFileList { get; set; }
    [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false)]
    public bool EnableMediaOnHoldForQueuedCalls { get; set; }
    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceModify17 MediaOnHoldSource { get; set; }
    [XmlElement(ElementName = "playWhisperMessage", IsNullable = false)]
    public bool PlayWhisperMessage { get; set; }
    [XmlElement(ElementName = "whisperAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "whisperMessageAudioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify WhisperMessageAudioUrlList { get; set; }
    [XmlElement(ElementName = "whisperMessageAudioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify WhisperMessageAudioFileList { get; set; }
    [XmlElement(ElementName = "whisperVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "whisperMessageVideoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify WhisperMessageVideoUrlList { get; set; }
    [XmlElement(ElementName = "whisperMessageVideoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify WhisperMessageVideoFileList { get; set; }
    [XmlElement(ElementName = "estimatedWaitMessageOptionsModify", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EstimatedWaitMessageOptionsModify EstimatedWaitMessageOptionsModify { get; set; }
 }
}
