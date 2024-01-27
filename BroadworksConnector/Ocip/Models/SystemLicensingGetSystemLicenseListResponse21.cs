using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10644""}]")]
    public class SystemLicensingGetSystemLicenseListResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.SystemLicenseType21> _license = new List<BroadWorksConnector.Ocip.Models.SystemLicenseType21>();

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10644")]
        public List<BroadWorksConnector.Ocip.Models.SystemLicenseType21> License
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
