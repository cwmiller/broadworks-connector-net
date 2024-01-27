using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system's provisioning validation attributes.
    /// The response is either a SystemProvisioningValidationGetResponse25 or ErrorResponse.
    /// <see cref="SystemProvisioningValidationGetResponse25"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14911""}]")]
    public class SystemProvisioningValidationGetRequest25 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemProvisioningValidationGetResponse25>
    {

    }
}
