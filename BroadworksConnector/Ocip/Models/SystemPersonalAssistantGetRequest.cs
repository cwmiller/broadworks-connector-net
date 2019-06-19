using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get system Personal Assistant Parameters.
    /// The response is either SystemPersonalAssistantGetResponse or ErrorResponse.
    /// <see cref="SystemPersonalAssistantGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemPersonalAssistantGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
