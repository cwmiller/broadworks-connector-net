using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system level data associated with Call Processing Policy.
    /// The response is either a SystemCallProcessingGetPolicyResponse16 or an
    /// ErrorResponse.
    /// <see cref="SystemCallProcessingGetPolicyResponse16"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21305""}]")]
    public class SystemCallProcessingGetPolicyRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
