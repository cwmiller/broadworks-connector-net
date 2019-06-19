using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse15 or an ErrorResponse.
    /// Replaced By: SystemSubscriberGetCallProcessingParametersRequest15sp2
    /// <see cref="SystemSubscriberGetCallProcessingParametersResponse15"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSubscriberGetCallProcessingParametersRequest15sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:10667""}]")]
    public class SystemSubscriberGetCallProcessingParametersRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
