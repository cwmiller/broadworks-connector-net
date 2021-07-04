using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of provisioned prefixes in the system.
    /// The response is either a SystemCLIDDeliveryPrefixGetListResponse or an ErrorResponse.
    /// <see cref="SystemCLIDDeliveryPrefixGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5333""}]")]
    public class SystemCLIDDeliveryPrefixGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
