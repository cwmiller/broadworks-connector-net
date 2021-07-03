using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8486""}]")]
    public class SystemLicensingGetSystemLicenseListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<BroadWorksConnector.Ocip.Models.SystemLicenseType> _license = new List<BroadWorksConnector.Ocip.Models.SystemLicenseType>();

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:8486")]
        public List<BroadWorksConnector.Ocip.Models.SystemLicenseType> License
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
