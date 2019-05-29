using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPreAlertingAnnouncementGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "announcementInterruption", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PreAlertingAnnouncementInterrupt AnnouncementInterruption { get; set; }
    [XmlElement(ElementName = "interruptionDigitSequence", IsNullable = false)]
    public string InterruptionDigitSequence { get; set; }
    [XmlElement(ElementName = "audioSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey AudioFile { get; set; }
    [XmlElement(ElementName = "audioFileUrl", IsNullable = false)]
    public string AudioFileUrl { get; set; }
    [XmlElement(ElementName = "videoSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey VideoFile { get; set; }
    [XmlElement(ElementName = "videoFileUrl", IsNullable = false)]
    public string VideoFileUrl { get; set; }
 }
}
