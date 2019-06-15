using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetSystemLicenseListRequest21.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest21sp1.
        /// <see cref="SystemLicensingGetSystemLicenseListRequest21"/>
        /// <see cref="SystemLicensingGetSystemLicenseListRequest21sp1"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetSystemLicenseListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.SystemLicenseType21> _license;

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SystemLicenseType21> License {
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
