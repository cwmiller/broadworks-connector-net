using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system provisioning configuration for all subscribers
    /// The response is either a SystemSubscriberGetProvisioningParametersResponse23
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemSubscriberGetProvisioningParametersRequest24V2.
    /// <see cref="SystemSubscriberGetProvisioningParametersResponse23"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSubscriberGetProvisioningParametersRequest24V2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:35925""}]")]
    public class SystemSubscriberGetProvisioningParametersRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSubscriberGetProvisioningParametersResponse23>
    {

    }
}
