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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10610""}]")]
    public class SystemLicensingGetSystemLicenseListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<BroadWorksConnector.Ocip.Models.SystemLicenseType> _license = new List<BroadWorksConnector.Ocip.Models.SystemLicenseType>();

        [XmlElement(ElementName = "license", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:10610")]
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
