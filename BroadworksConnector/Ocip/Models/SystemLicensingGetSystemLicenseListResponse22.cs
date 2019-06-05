using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLicensingGetSystemLicenseListResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.SystemLicenseType22> _license;

    [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SystemLicenseType22> License {
        get => _license;
        set {
            LicenseSpecified = true;
            _license = value;
        }
    }

    [XmlIgnore]
    public bool LicenseSpecified { get; set; }
}
}
