using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of External Emergency Routing system parameters.
    /// The response is either SystemExternalEmergencyRoutingParametersGetResponse13mp13 or ErrorResponse.
    /// <see cref="SystemExternalEmergencyRoutingParametersGetResponse13mp13"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10108""}]")]
    public class SystemExternalEmergencyRoutingParametersGetRequest13mp13 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemExternalEmergencyRoutingParametersGetResponse13mp13>
    {

    }
}
