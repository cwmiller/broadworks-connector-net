using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceRead22V2 
{
    [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AudioFileCodec22 AudioFilePreferredCodec { get; set; }
    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSourceSelection { get; set; }
    [XmlElement(ElementName = "labeledCustomSourceMediaFiles", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceRead22V2LabeledCustomSourceMediaFiles LabeledCustomSourceMediaFiles { get; set; }
    [XmlElement(ElementName = "announcementCustomSourceMediaFiles", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceRead22V2AnnouncementCustomSourceMediaFiles AnnouncementCustomSourceMediaFiles { get; set; }
    [XmlElement(ElementName = "externalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceRead22V2ExternalSource ExternalSource { get; set; }
 }
}
