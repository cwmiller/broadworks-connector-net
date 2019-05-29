using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLicensingGetSystemLicenseListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "license", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SystemLicenseType22> License { get; set; }
 }
}
