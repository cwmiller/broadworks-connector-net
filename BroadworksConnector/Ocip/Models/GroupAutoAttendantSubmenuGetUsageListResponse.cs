using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantSubmenuGetUsageListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "submenuTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable SubmenuTable { get; set; }
 }
}
