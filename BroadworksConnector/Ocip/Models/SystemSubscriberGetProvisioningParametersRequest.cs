using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system provisioning configuration for all subscribers
    /// The response is either a SystemSubscriberGetProvisioningParametersResponse
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemSubscriberGetProvisioningParametersRequest24
    /// <see cref="SystemSubscriberGetProvisioningParametersResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSubscriberGetProvisioningParametersRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:35257""}]")]
    public class SystemSubscriberGetProvisioningParametersRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
