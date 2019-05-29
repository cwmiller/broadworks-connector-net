using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterGetAnnouncementResponse16 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "playEntranceMessage", IsNullable = false)]
    public bool PlayEntranceMessage { get; set; }
    [XmlElement(ElementName = "mandatoryEntranceMessage", IsNullable = false)]
    public bool MandatoryEntranceMessage { get; set; }
    [XmlElement(ElementName = "entranceAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceAudioFileUrl", IsNullable = false)]
    public string EntranceAudioFileUrl { get; set; }
    [XmlElement(ElementName = "entranceMessageAudioFileDescription", IsNullable = false)]
    public string EntranceMessageAudioFileDescription { get; set; }
    [XmlElement(ElementName = "entranceAudioFileMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType EntranceAudioFileMediaType { get; set; }
    [XmlElement(ElementName = "entranceVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection EntranceVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "entranceVideoFileUrl", IsNullable = false)]
    public string EntranceVideoFileUrl { get; set; }
    [XmlElement(ElementName = "entranceMessageVideoFileDescription", IsNullable = false)]
    public string EntranceMessageVideoFileDescription { get; set; }
    [XmlElement(ElementName = "entranceVideoFileMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType EntranceVideoFileMediaType { get; set; }
    [XmlElement(ElementName = "playPeriodicComfortMessage", IsNullable = false)]
    public bool PlayPeriodicComfortMessage { get; set; }
    [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false)]
    public int TimeBetweenComfortMessagesSeconds { get; set; }
    [XmlElement(ElementName = "periodicComfortAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortAudioFileUrl", IsNullable = false)]
    public string PeriodicComfortAudioFileUrl { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageAudioFileDescription", IsNullable = false)]
    public string PeriodicComfortMessageAudioFileDescription { get; set; }
    [XmlElement(ElementName = "periodicComfortAudioFileMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType PeriodicComfortAudioFileMediaType { get; set; }
    [XmlElement(ElementName = "periodicComfortVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection PeriodicComfortVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "periodicComfortVideoFileUrl", IsNullable = false)]
    public string PeriodicComfortVideoFileUrl { get; set; }
    [XmlElement(ElementName = "periodicComfortMessageVideoFileDescription", IsNullable = false)]
    public string PeriodicComfortMessageVideoFileDescription { get; set; }
    [XmlElement(ElementName = "periodicComfortVideoFileMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType PeriodicComfortVideoFileMediaType { get; set; }
    [XmlElement(ElementName = "enableMediaOnHoldForQueuedCalls", IsNullable = false)]
    public bool EnableMediaOnHoldForQueuedCalls { get; set; }
    [XmlElement(ElementName = "mediaOnHoldSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 MediaOnHoldSource { get; set; }
    [XmlElement(ElementName = "mediaOnHoldUseAlternateSourceForInternalCalls", IsNullable = false)]
    public bool MediaOnHoldUseAlternateSourceForInternalCalls { get; set; }
    [XmlElement(ElementName = "mediaOnHoldInternalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldSourceRead16 MediaOnHoldInternalSource { get; set; }
 }
}
