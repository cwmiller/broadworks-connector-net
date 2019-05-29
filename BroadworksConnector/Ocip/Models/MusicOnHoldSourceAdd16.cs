using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceAdd16 
{
    [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec AudioFilePreferredCodec { get; set; }
    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSourceSelection { get; set; }
    [XmlElement(ElementName = "customSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd16CustomSource CustomSource { get; set; }
    [XmlElement(ElementName = "externalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd16ExternalSource ExternalSource { get; set; }
 }
}
