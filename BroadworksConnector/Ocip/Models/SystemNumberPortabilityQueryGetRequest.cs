using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system Number Portability Query Parameters.
    /// The response is either SystemNumberPortabilityQueryGetResponse or ErrorResponse.
    /// <see cref="SystemNumberPortabilityQueryGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemNumberPortabilityQueryGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
