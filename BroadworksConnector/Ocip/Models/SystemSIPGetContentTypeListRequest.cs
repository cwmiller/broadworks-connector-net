using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the content type list for the SIP interface.
    /// The response is either SystemSIPGetContentTypeListResponse or ErrorResponse.
    /// <see cref="SystemSIPGetContentTypeListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:16665""}]")]
    public class SystemSIPGetContentTypeListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
