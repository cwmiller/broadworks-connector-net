using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetResponse or an ErrorResponse.
    /// Replaced By: SystemAutomaticCallbackGetRequest15
    /// <see cref="SystemAutomaticCallbackGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAutomaticCallbackGetRequest15"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:4267""}]")]
    public class SystemAutomaticCallbackGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
