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
    /// <see cref="SystemProvisioningValidationGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13596""}]")]
    public class SystemProvisioningValidationGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
