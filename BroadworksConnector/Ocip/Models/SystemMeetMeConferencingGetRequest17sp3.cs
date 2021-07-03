using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Meet-Me Conferencing functions.
    /// The response is either a SystemMeetMeConferencingGetResponse17sp3 or an ErrorResponse.
    /// 
    /// Replaced by: SystemMeetMeConferencingGetRequest18
    /// <see cref="SystemMeetMeConferencingGetResponse17sp3"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemMeetMeConferencingGetRequest18"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:27643""}]")]
    public class SystemMeetMeConferencingGetRequest17sp3 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
