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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""77f32f6c8e214eb5c1a80dedfce1cb56:131""}]")]
    public abstract class OCIResponse : BroadWorksConnector.Ocip.Models.C.OCICommand
    {

    }
}
