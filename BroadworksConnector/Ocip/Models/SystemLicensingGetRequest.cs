using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get all the licensing information.
    /// The response is either SystemLicensingGetResponse or ErrorResponse.
    /// Replaced By: SystemLicensingGetRequest14sp3
    /// <see cref="SystemLicensingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemLicensingGetRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27422""}]")]
    public class SystemLicensingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
