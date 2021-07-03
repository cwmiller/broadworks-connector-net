using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system licenses in the system.
    /// The response is either a SystemLicensingGetSystemLicenseListResponse21 or an ErrorResponse.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest21sp1.
    /// <see cref="SystemLicensingGetSystemLicenseListResponse21"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemLicensingGetSystemLicenseListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8423""}]")]
    public class SystemLicensingGetSystemLicenseListRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
