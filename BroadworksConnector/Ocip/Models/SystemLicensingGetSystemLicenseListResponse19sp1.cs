using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3214""}]")]
    public class SystemLicensingGetSystemLicenseListResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.SystemLicenseType19sp1> _license = new List<BroadWorksConnector.Ocip.Models.SystemLicenseType19sp1>();

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3214")]
        public List<BroadWorksConnector.Ocip.Models.SystemLicenseType19sp1> License
        {
            get => _license;
            set
            {
                LicenseSpecified = true;
                _license = value;
            }
        }

        [XmlIgnore]
        public bool LicenseSpecified { get; set; }

    }
}
