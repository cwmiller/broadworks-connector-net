using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system licenses in the system.
    /// The response is either a SystemLicensingGetSystemLicenseListResponse22 or an ErrorResponse.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest22V2.
    /// <see cref="SystemLicensingGetSystemLicenseListResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemLicensingGetSystemLicenseListRequest22V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:8471""}]")]
    public class SystemLicensingGetSystemLicenseListRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
