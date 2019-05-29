using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceAdd22 
{
    [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec22 AudioFilePreferredCodec { get; set; }
    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSourceSelection { get; set; }
    [XmlElement(ElementName = "labeledCustomSourceMediaFiles", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd22LabeledCustomSourceMediaFiles LabeledCustomSourceMediaFiles { get; set; }
    [XmlElement(ElementName = "announcementCustomSourceMediaFiles", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd22AnnouncementCustomSourceMediaFiles AnnouncementCustomSourceMediaFiles { get; set; }
    [XmlElement(ElementName = "externalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceAdd22ExternalSource ExternalSource { get; set; }
 }
}
