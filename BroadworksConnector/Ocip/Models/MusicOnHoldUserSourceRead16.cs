using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldUserSourceRead16 
{
    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldUserMessageSelection MessageSourceSelection { get; set; }
    [XmlElement(ElementName = "customSource", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MusicOnHoldUserSourceRead16CustomSource CustomSource { get; set; }
 }
}
