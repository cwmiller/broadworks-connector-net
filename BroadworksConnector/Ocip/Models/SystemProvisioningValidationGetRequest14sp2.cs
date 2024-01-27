using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system's provisioning validation attributes.
    /// The response is either a SystemProvisioningValidationGetResponse14sp2 or ErrorResponse.
    /// <see cref="SystemProvisioningValidationGetResponse14sp2"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:11455""}]")]
    public class SystemProvisioningValidationGetRequest14sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemProvisioningValidationGetResponse14sp2>
    {

    }
}
