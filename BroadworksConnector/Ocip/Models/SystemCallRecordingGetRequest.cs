using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Recording.
    /// The response is either a SystemCallRecordingGetResponse or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallRecordingGetRequest22
    /// <see cref="SystemCallRecordingGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallRecordingGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:9246""}]")]
    public class SystemCallRecordingGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallRecordingGetResponse>
    {

    }
}
