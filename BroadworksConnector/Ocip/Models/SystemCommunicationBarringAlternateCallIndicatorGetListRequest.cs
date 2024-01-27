using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get all the Communication Barring Alternate Call Indicator defined
    /// in the system. The response is either a SystemCommunicationBarringAlternateCallIndicatorGetListResponse or an ErrorResponse.
    /// <see cref="SystemCommunicationBarringAlternateCallIndicatorGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:5649""}]")]
    public class SystemCommunicationBarringAlternateCallIndicatorGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCommunicationBarringAlternateCallIndicatorGetListResponse>
    {

    }
}
