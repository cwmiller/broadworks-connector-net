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
    /// 
    /// Replaced by: SystemCallingNameRetrievalGetRequest24
    /// <see cref="SystemCallingNameRetrievalGetResponse17sp4"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallingNameRetrievalGetRequest24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21807""}]")]
    public class SystemCallingNameRetrievalGetRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallingNameRetrievalGetResponse17sp4>
    {

    }
}
