using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse18sp1
    /// or an ErrorResponse.
    /// <see cref="SystemSubscriberGetCallProcessingParametersResponse18sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18204""}]")]
    public class SystemSubscriberGetCallProcessingParametersRequest18sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSubscriberGetCallProcessingParametersResponse18sp1>
    {

    }
}
