using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's calling name retrieval attributes.
    /// The response is either a SystemCallingNameRetrievalGetResponse24 or an ErrorResponse.
    /// <see cref="SystemCallingNameRetrievalGetResponse24"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7abfb1e02a3465af832e0a8a8adfc741:46""}]")]
    public class SystemCallingNameRetrievalGetRequest24 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
