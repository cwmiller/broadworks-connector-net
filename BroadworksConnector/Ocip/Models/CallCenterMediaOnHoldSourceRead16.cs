using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterMediaOnHoldSourceRead16 
{
    [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection AudioMessageSourceSelection { get; set; }
    [XmlElement(ElementName = "audioFileUrl", IsNullable = false)]
    public string AudioFileUrl { get; set; }
    [XmlElement(ElementName = "audioFileDescription", IsNullable = false)]
    public string AudioFileDescription { get; set; }
    [XmlElement(ElementName = "audioFileMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType AudioFileMediaType { get; set; }
    [XmlElement(ElementName = "externalAudioSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 ExternalAudioSource { get; set; }
    [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection VideoMessageSourceSelection { get; set; }
    [XmlElement(ElementName = "videoFileUrl", IsNullable = false)]
    public string VideoFileUrl { get; set; }
    [XmlElement(ElementName = "videoFileDescription", IsNullable = false)]
    public string VideoFileDescription { get; set; }
    [XmlElement(ElementName = "videoFileMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VideoFileMediaType { get; set; }
    [XmlElement(ElementName = "externalVideoSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointRead14 ExternalVideoSource { get; set; }
 }
}
