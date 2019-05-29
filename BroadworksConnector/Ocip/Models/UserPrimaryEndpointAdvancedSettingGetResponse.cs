using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPrimaryEndpointAdvancedSettingGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "allowOrigination", IsNullable = false)]
    public bool AllowOrigination { get; set; }
    [XmlElement(ElementName = "allowTermination", IsNullable = false)]
    public bool AllowTermination { get; set; }
 }
}
