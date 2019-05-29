using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterMediaOnHoldSourceRead22 
{
    [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection AudioMessageSourceSelection { get; set; }
    [XmlElement(ElementName = "audioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList { get; set; }
    [XmlElement(ElementName = "audioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 AudioFileList { get; set; }
    [XmlElement(ElementName = "externalAudioSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 ExternalAudioSource { get; set; }
    [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection VideoMessageSourceSelection { get; set; }
    [XmlElement(ElementName = "videoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList { get; set; }
    [XmlElement(ElementName = "videoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 VideoFileList { get; set; }
    [XmlElement(ElementName = "externalVideoSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead22 ExternalVideoSource { get; set; }
 }
}
