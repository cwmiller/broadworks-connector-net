using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system licenses in the system.
    /// The response is either a SystemLicensingGetSystemLicenseListResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest21 in AS data mode
    /// <see cref="SystemLicensingGetSystemLicenseListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemLicensingGetSystemLicenseListRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3134""}]")]
    public class SystemLicensingGetSystemLicenseListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
