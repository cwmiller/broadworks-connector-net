using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's calling name retrieval attributes.
    /// The response is either a SystemCallingNameRetrievalGetResponse20 or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallingNameRetrievalGetRequest24
    /// <see cref="SystemCallingNameRetrievalGetResponse20"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallingNameRetrievalGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21053""}]")]
    public class SystemCallingNameRetrievalGetRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
