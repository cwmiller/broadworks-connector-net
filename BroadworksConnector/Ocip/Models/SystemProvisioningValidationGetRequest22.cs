using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system's provisioning validation attributes.
    /// The response is either a SystemProvisioningValidationGetResponse22 or ErrorResponse.
    /// Replaced by SystemProvisioningValidationGetRequest25.
    /// <see cref="SystemProvisioningValidationGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemProvisioningValidationGetRequest25"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:11470""}]")]
    public class SystemProvisioningValidationGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemProvisioningValidationGetResponse22>
    {

    }
}
