using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's calling name retrieval attributes.
    /// The response is either a SystemCallingNameRetrievalGetResponse17sp4 or an ErrorResponse.
    /// <see cref="SystemCallingNameRetrievalGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:31421""}]")]
    public class SystemCallingNameRetrievalGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
