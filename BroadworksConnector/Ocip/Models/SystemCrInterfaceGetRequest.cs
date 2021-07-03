using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Gets the system level attributes of the Cr Interface.
    /// The response is either a SystemCrInterfaceGetResponse or an ErrorResponse.
    /// <see cref="SystemCrInterfaceGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:25619""}]")]
    public class SystemCrInterfaceGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
