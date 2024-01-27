using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the GETS system settings.
    /// The response is either SystemGETSGetResponse or ErrorResponse.
    /// Replaced By: SystemGETSGetRequest22
    /// <see cref="SystemGETSGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemGETSGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemGETSGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemGETSGetResponse>
    {

    }
}
