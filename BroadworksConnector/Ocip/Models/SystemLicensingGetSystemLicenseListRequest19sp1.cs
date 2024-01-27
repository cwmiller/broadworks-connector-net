using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of system licenses in the system.
    /// The response is either a SystemLicensingGetSystemLicenseListResponse19sp1 or an ErrorResponse.
    /// 
    /// Replaced by: SystemLicensingGetSystemLicenseListRequest21sp1.
    /// <see cref="SystemLicensingGetSystemLicenseListResponse19sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemLicensingGetSystemLicenseListRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:10547""}]")]
    public class SystemLicensingGetSystemLicenseListRequest19sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLicensingGetSystemLicenseListResponse19sp1>
    {

    }
}
