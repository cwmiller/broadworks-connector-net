using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceMusicOnHoldInfo 
{
    [XmlElement(ElementName = "enableVideo", IsNullable = false)]
    public bool EnableVideo { get; set; }
    [XmlElement(ElementName = "source", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldUserSourceRead16 Source { get; set; }
    [XmlElement(ElementName = "useAlternateSourceForInternalCalls", IsNullable = false)]
    public bool UseAlternateSourceForInternalCalls { get; set; }
    [XmlElement(ElementName = "internalSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldUserSourceRead16 InternalSource { get; set; }
 }
}
