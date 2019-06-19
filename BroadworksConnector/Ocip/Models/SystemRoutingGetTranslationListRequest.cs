using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the system digit routing table.
    /// The response is either a SystemRoutingGetTranslationListResponse or an ErrorResponse.
    /// <see cref="SystemRoutingGetTranslationListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:14307""}]")]
    public class SystemRoutingGetTranslationListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
