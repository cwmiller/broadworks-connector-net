using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// AvailabilityTestRequest is for high-availability support.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="AvailabilityTestRequest"/>
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6b27fcc79475236456fc113a42b75543:133""}]")]
    public class AvailabilityTestRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
