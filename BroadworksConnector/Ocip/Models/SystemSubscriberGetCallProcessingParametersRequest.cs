using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system call processing configuration for all subscribers
    /// The response is either a SystemSubscriberGetCallProcessingParametersResponse or an ErrorResponse.
    /// Replaced By: SystemSubscriberGetCallProcessingParametersRequest14sp3
    /// <see cref="SystemSubscriberGetCallProcessingParametersResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSubscriberGetCallProcessingParametersRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:35626""}]")]
    public class SystemSubscriberGetCallProcessingParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSubscriberGetCallProcessingParametersResponse>
    {

    }
}
