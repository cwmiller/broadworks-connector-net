using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Call Processing Policy Profiles.
    /// The response is either a SystemCallProcessingPolicyProfileGetListResponse
    /// or an ErrorResponse.
    /// <see cref="SystemCallProcessingPolicyProfileGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:3555""}]")]
    public class SystemCallProcessingPolicyProfileGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
