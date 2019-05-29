using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCustomContactDirectoryEntryList 
{
    [XmlElement(ElementName = "entry", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CustomContactDirectoryEntry> Entry { get; set; }
 }
}
