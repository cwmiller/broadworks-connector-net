using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetSystemLicenseListRequest22.
        /// <see cref="SystemLicensingGetSystemLicenseListRequest22"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemLicensingGetSystemLicenseListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private List<BroadWorksConnector.Ocip.Models.SystemLicenseType22> _license;

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        public List<BroadWorksConnector.Ocip.Models.SystemLicenseType22> License {
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
