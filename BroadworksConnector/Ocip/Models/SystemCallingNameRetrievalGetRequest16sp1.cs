using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's calling name retrieval attributes.
    /// The response is either a SystemCallingNameRetrievalGetResponse16sp1 or an ErrorResponse.
    /// 
    /// Replaced by: SystemCallingNameRetrievalGetRequest17sp4
    /// <see cref="SystemCallingNameRetrievalGetResponse16sp1"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallingNameRetrievalGetRequest17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21791""}]")]
    public class SystemCallingNameRetrievalGetRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallingNameRetrievalGetResponse16sp1>
    {

    }
}
