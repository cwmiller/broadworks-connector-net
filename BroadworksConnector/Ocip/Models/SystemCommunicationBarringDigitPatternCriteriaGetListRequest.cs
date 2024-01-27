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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:6036""}]")]
    public class SystemCommunicationBarringDigitPatternCriteriaGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCommunicationBarringDigitPatternCriteriaGetListResponse>
    {

    }
}
