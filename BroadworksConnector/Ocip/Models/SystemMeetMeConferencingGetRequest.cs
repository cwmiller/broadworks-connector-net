using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Meet-Me Conferencing functions.
    /// The response is either a SystemMeetMeConferencingGetResponse or an ErrorResponse.
    /// 
    /// Replaced by: SystemMeetMeConferencingGetRequest17sp3
    /// <see cref="SystemMeetMeConferencingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemMeetMeConferencingGetRequest17sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27627""}]")]
    public class SystemMeetMeConferencingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMeetMeConferencingGetResponse>
    {

    }
}
