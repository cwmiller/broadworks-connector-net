using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLicensingGetSystemLicenseListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.SystemLicenseType> _license;

    [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SystemLicenseType> License {
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
