using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Selective Services.
    /// The response is either a SystemSelectiveServicesGetResponse or an
    /// ErrorResponse.
    /// <see cref="SystemSelectiveServicesGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26377""}]")]
    public class SystemSelectiveServicesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
