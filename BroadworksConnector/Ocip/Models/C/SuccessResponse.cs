using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The SuccessResponse is concrete response sent whenever a transaction is successful and does not return any data.
    /// <see cref="SuccessResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5a0dbb6ff453924acebff71a89ec0dc8:188""}]")]
    public class SuccessResponse : BroadWorksConnector.Ocip.Models.C.OCIResponse
    {

    }
}
