using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of all system-level Application Server aliases.
    /// The response is either SystemAliasGetListResponse or ErrorResponse.
    /// <see cref="SystemAliasGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2234""}]")]
    public class SystemAliasGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
