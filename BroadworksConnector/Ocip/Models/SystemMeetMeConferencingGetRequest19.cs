using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Meet-Me Conferencing functions.
    /// The response is either a SystemMeetMeConferencingGetResponse19 or an ErrorResponse.
    /// <see cref="SystemMeetMeConferencingGetResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:448""}]")]
    public class SystemMeetMeConferencingGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMeetMeConferencingGetResponse19>
    {

    }
}
