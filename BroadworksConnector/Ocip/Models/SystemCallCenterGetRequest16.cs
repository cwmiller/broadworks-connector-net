using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Center.
    /// The response is either a SystemCallCenterGetResponse16 or an
    /// ErrorResponse.
    /// 
    /// Replaced by: SystemCallCenterGetRequest17
    /// <see cref="SystemCallCenterGetResponse16"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallCenterGetRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21535""}]")]
    public class SystemCallCenterGetRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemCallCenterGetResponse16>
    {

    }
}
