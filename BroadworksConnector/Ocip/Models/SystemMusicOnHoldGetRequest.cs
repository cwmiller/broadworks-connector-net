using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Music On Hold.
    /// The response is either a SystemMusicOnHoldGetResponse or an
    /// ErrorResponse.
    /// <see cref="SystemMusicOnHoldGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""66fe518a637c74cc4b2c97aa7f68fc49:200""}]")]
    public class SystemMusicOnHoldGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
