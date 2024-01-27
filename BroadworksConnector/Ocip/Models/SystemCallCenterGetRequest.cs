using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Center.
    /// The response is either a SystemCallCenterGetResponse or an
    /// ErrorResponse.
    /// Replaced By: SystemCallCenterGetRequest14sp9
    /// <see cref="SystemCallCenterGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallCenterGetRequest14sp9"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21501""}]")]
    public class SystemCallCenterGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterGetResponse>
    {

    }
}
