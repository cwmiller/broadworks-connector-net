using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system provisioning configuration for all subscribers
    /// The response is either a SystemSubscriberGetProvisioningParametersResponse24
    /// or an ErrorResponse.
    /// <see cref="SystemSubscriberGetProvisioningParametersResponse24"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18040""}]")]
    public class SystemSubscriberGetProvisioningParametersRequest24 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSubscriberGetProvisioningParametersResponse24>
    {

    }
}
