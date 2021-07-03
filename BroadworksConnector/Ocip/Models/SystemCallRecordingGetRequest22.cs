using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Recording.
    /// The response is either a SystemCallRecordingGetResponse22 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallRecordingGetRequest23
    /// <see cref="SystemCallRecordingGetResponse22"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallRecordingGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:24696""}]")]
    public class SystemCallRecordingGetRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
