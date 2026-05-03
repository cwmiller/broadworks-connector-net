using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system provisioning configuration for all subscribers
    /// The response is either a SystemSubscriberGetProvisioningParametersResponse23V2
    /// or an ErrorResponse.
    /// 
    /// Replaced by: SystemSubscriberGetProvisioningParametersRequest24V3.
    /// <see cref="SystemSubscriberGetProvisioningParametersResponse23V2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemSubscriberGetProvisioningParametersRequest24V3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:40131""}]")]
    public class SystemSubscriberGetProvisioningParametersRequest23V2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemSubscriberGetProvisioningParametersResponse23V2>
    {

    }
}
