using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Requests the list of state and province names.
    /// The response is either SystemStateOrProvinceGetListResponse or ErrorResponse.
    /// <see cref="SystemStateOrProvinceGetListResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17861""}]")]
    public class SystemStateOrProvinceGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
