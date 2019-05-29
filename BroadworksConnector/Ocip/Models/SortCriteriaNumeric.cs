using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
[XmlInclude(typeof(BroadworksConnector.Ocip.Models.SortByAnnouncementFileSize))]
public abstract class SortCriteriaNumeric 
{
    [XmlElement(ElementName = "isAscending", IsNullable = false)]
    public bool IsAscending { get; set; }
 }
}
