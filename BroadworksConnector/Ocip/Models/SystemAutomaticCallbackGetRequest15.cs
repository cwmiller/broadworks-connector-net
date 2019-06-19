using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetResponse15 or an ErrorResponse.
    /// Replaced By: SystemAutomaticCallbackGetRequest15sp2
    /// <see cref="SystemAutomaticCallbackGetResponse15"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAutomaticCallbackGetRequest15sp2"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:9947""}]")]
    public class SystemAutomaticCallbackGetRequest15 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
