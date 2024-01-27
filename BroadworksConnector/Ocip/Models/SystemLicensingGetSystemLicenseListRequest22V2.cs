using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system licenses in the system.
    /// The response is either a SystemLicensingGetSystemLicenseListResponse22V2 or an ErrorResponse.
    /// <see cref="SystemLicensingGetSystemLicenseListResponse22V2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11661""}]")]
    public class SystemLicensingGetSystemLicenseListRequest22V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLicensingGetSystemLicenseListResponse22V2>
    {

    }
}
