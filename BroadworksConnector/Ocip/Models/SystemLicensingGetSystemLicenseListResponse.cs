using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetSystemLicenseListRequest.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListResponse21 in AS data mode
        /// <see cref="SystemLicensingGetSystemLicenseListRequest"/>
        /// <see cref="SystemLicensingGetSystemLicenseListResponse21"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetSystemLicenseListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.SystemLicenseType> _license;

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SystemLicenseType> License {
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
