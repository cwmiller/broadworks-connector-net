using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Digit Pattern Criteria defined at the system level.
    /// The response is either a SystemCommunicationBarringDigitPatternCriteriaGetListResponse or an ErrorResponse.
    /// <see cref="SystemCommunicationBarringDigitPatternCriteriaGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5618""}]")]
    public class SystemCommunicationBarringDigitPatternCriteriaGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
