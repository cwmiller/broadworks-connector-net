using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemLicensingGetSystemLicenseListResponse21sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.SystemLicenseType21sp1> _license;

    [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SystemLicenseType21sp1> License {
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
