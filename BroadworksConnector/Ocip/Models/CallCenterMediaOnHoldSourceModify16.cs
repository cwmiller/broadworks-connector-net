using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterMediaOnHoldSourceModify16 
{
    [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection AudioMessageSourceSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile { get; set; }
    [XmlElement(ElementName = "externalAudioSource", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify ExternalAudioSource { get; set; }
    [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection VideoMessageSourceSelection { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile { get; set; }
    [XmlElement(ElementName = "externalVideoSource", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify ExternalVideoSource { get; set; }
 }
}
