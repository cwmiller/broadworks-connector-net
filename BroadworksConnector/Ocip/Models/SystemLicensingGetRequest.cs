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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:27904""}]")]
    public class SystemLicensingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemLicensingGetResponse>
    {

    }
}
