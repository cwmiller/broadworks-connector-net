using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Resource Priority service attributes.
    /// The response is either SystemResourcePriorityGetResponse or ErrorResponse.
    /// <see cref="SystemResourcePriorityGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemResourcePriorityGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
