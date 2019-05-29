using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAttendantConsoleGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "launchOnLogin", IsNullable = false)]
    public bool LaunchOnLogin { get; set; }
    [XmlElement(ElementName = "allowUserConfigCallDetails", IsNullable = false)]
    public bool AllowUserConfigCallDetails { get; set; }
    [XmlElement(ElementName = "allowUserViewCallDetails", IsNullable = false)]
    public bool AllowUserViewCallDetails { get; set; }
    [XmlElement(ElementName = "displayColumn", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AttendantConsoleDisplayColumn> DisplayColumn { get; set; }
 }
}
