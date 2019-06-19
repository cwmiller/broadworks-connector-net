using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse17sp4
    /// or an ErrorResponse.
    /// 
    /// Replaced by SystemSubscriberGetCallProcessingParametersRequest18sp1.
    /// <see cref="SystemSubscriberGetCallProcessingParametersResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSubscriberGetCallProcessingParametersRequest18sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26965""}]")]
    public class SystemSubscriberGetCallProcessingParametersRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
