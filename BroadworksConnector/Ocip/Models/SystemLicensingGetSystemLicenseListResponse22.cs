using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetSystemLicenseListRequest22.
    /// Replaced by: SystemLicensingGetSystemLicenseListResponse22V2.
    /// <see cref="SystemLicensingGetSystemLicenseListRequest22"/>
    /// <see cref="SystemLicensingGetSystemLicenseListResponse22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8553""}]")]
    public class SystemLicensingGetSystemLicenseListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.SystemLicenseType22> _license = new List<BroadWorksConnector.Ocip.Models.SystemLicenseType22>();

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8553")]
        public List<BroadWorksConnector.Ocip.Models.SystemLicenseType22> License
        {
            get => _license;
            set
            {
                LicenseSpecified = true;
                _license = value;
            }
        }

        [XmlIgnore]
        protected bool LicenseSpecified { get; set; }

    }
}
