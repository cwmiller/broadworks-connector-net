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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10677""}]")]
    public class SystemLicensingGetSystemLicenseListResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.SystemLicenseType22> _license = new List<BroadWorksConnector.Ocip.Models.SystemLicenseType22>();

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10677")]
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
