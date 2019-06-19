using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse17
    /// or an ErrorResponse.
    /// <see cref="SystemSubscriberGetCallProcessingParametersResponse17"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:22562""}]")]
    public class SystemSubscriberGetCallProcessingParametersRequest17 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
