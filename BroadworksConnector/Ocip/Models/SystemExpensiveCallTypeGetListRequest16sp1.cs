using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get the list of expensive alternate call indicators in the system.
    /// The response is either a SystemExpensiveCallTypeGetListResponse16sp1
    /// or an ErrorResponse.
    /// <see cref="SystemExpensiveCallTypeGetListResponse16sp1"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8850""}]")]
    public class SystemExpensiveCallTypeGetListRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
