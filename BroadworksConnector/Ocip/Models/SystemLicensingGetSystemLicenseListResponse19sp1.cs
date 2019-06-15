using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetSystemLicenseListRequest19sp1.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest21sp1.
        /// <see cref="SystemLicensingGetSystemLicenseListRequest19sp1"/>
        /// <see cref="SystemLicensingGetSystemLicenseListRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetSystemLicenseListResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.SystemLicenseType19sp1> _license;

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SystemLicenseType19sp1> License {
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
