using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceRead20 
{
    [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec AudioFilePreferredCodec { get; set; }
    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSourceSelection { get; set; }
    [XmlElement(ElementName = "customSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceRead20CustomSource CustomSource { get; set; }
    [XmlElement(ElementName = "externalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceRead20ExternalSource ExternalSource { get; set; }
 }
}
