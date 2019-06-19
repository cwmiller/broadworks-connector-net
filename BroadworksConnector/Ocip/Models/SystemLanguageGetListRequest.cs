using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the defined languages in the system.
    /// The response is either a SystemLanguageGetListResponse or an ErrorResponse.
    /// <see cref="SystemLanguageGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10403""}]")]
    public class SystemLanguageGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
