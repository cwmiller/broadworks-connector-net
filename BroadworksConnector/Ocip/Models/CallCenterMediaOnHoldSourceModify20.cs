using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterMediaOnHoldSourceModify20 
{
    [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection AudioMessageSourceSelection { get; set; }
    [XmlElement(ElementName = "audioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify AudioUrlList { get; set; }
    [XmlElement(ElementName = "audioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 AudioFileList { get; set; }
    [XmlElement(ElementName = "externalAudioSource", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify ExternalAudioSource { get; set; }
    [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection VideoMessageSourceSelection { get; set; }
    [XmlElement(ElementName = "videoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify VideoUrlList { get; set; }
    [XmlElement(ElementName = "videoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 VideoFileList { get; set; }
    [XmlElement(ElementName = "externalVideoSource", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify ExternalVideoSource { get; set; }
 }
}
