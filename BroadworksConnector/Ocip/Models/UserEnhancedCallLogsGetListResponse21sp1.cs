using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserEnhancedCallLogsGetListResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "totalNumberOfRows", IsNullable = false)]
    public int TotalNumberOfRows { get; set; }
    [XmlElement(ElementName = "legacyEntry", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse21sp1LegacyEntry LegacyEntry { get; set; }
    [XmlElement(ElementName = "extendedEntry", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.UserEnhancedCallLogsGetListResponse21sp1ExtendedEntry ExtendedEntry { get; set; }
 }
}
