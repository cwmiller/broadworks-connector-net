using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The OCIResponse is an abstract type from which all responses are derived.
    /// <see cref="OCIResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.OCIDataResponse))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.SuccessResponse))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.ErrorResponse))]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5a0dbb6ff453924acebff71a89ec0dc8:154""}]")]
    public abstract class OCIResponse : BroadWorksConnector.Ocip.Models.C.OCICommand
    {

    }
}
