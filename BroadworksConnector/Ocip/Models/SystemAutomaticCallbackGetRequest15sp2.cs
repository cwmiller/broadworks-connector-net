using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's automatic callback attributes.
    /// The response is either a SystemAutomaticCallbackGetResponse15sp2 or an ErrorResponse.
    /// Replaced by: SystemAutomaticCallbackGetRequest17
    /// <see cref="SystemAutomaticCallbackGetResponse15sp2"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemAutomaticCallbackGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:14803""}]")]
    public class SystemAutomaticCallbackGetRequest15sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
