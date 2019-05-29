using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetAnnouncementResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "playEntranceMessage", IsNullable = false)]
    public bool PlayEntranceMessage { get; set; }
    [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false)]
    public bool MandatoryEntranceMessage { get; set; }
    [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceMessageAudioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList EntranceMessageAudioUrlList { get; set; }
    [XmlElement(ElementName = "entranceMessageAudioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 EntranceMessageAudioFileList { get; set; }
    [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceMessageVideoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList EntranceMessageVideoUrlList { get; set; }
    [XmlElement(ElementName = "entranceMessageVideoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 EntranceMessageVideoFileList { get; set; }
    [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false)]
    public bool PlayPeriodicComfortMessage { get; set; }
    [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false)]
    public int TimeBetweenComfortMessagesSeconds { get; set; }
    [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageAudioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList PeriodicComfortMessageAudioUrlList { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageAudioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 PeriodicComfortMessageAudioFileList { get; set; }
    [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageVideoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList PeriodicComfortMessageVideoUrlList { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageVideoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 PeriodicComfortMessageVideoFileList { get; set; }
    [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false)]
    public bool EnableMediaOnHoldForQueuedCalls { get; set; }
    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead20 MediaOnHoldSource { get; set; }
    [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false)]
    public bool MediaOnHoldUseAlternateSourceForInternalCalls { get; set; }
    [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead20 MediaOnHoldInternalSource { get; set; }
    [XmlElement(ElementName = "playWhisperMessage", IsNullable = false)]
    public bool PlayWhisperMessage { get; set; }
    [XmlElement(ElementName = "whisperAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "whisperMessageAudioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList WhisperMessageAudioUrlList { get; set; }
    [XmlElement(ElementName = "whisperMessageAudioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 WhisperMessageAudioFileList { get; set; }
    [XmlElement(ElementName = "whisperVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection WhisperVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "whisperMessageVideoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList WhisperMessageVideoUrlList { get; set; }
    [XmlElement(ElementName = "whisperMessageVideoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 WhisperMessageVideoFileList { get; set; }
    [XmlElement(ElementName = "estimatedWaitMessageOptionsRead", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EstimatedWaitMessageOptionsRead17sp4 EstimatedWaitMessageOptionsRead { get; set; }
 }
}
