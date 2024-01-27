using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the list of all Communication Barring Incoming Criteria.
    /// The response is either a SystemCommunicationBarringIncomingCriteriaGetListResponse or an ErrorResponse.
    /// <see cref="SystemCommunicationBarringIncomingCriteriaGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:6221""}]")]
    public class SystemCommunicationBarringIncomingCriteriaGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCommunicationBarringIncomingCriteriaGetListResponse>
    {

    }
}
