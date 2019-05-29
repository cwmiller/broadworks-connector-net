using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLocationBasedCallingRestrictionsGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "physicalLocationIndicator", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.PhysicalLocationIndicator PhysicalLocationIndicator { get; set; }
    [XmlElement(ElementName = "enforceMscValidation", IsNullable = false)]
    public bool EnforceMscValidation { get; set; }
    [XmlElement(ElementName = "enableOfficeZoneAnnouncement", IsNullable = false)]
    public bool EnableOfficeZoneAnnouncement { get; set; }
 }
}
