using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models.C
{
    /// <summary>
    /// The OCICommand is an abstract type from which all requests and responses are derived.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "C")]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.OCIRequest))]
    [XmlInclude(typeof(BroadWorksConnector.Ocip.Models.C.OCIResponse))]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5a0dbb6ff453924acebff71a89ec0dc8:111""}]")]
    public abstract class OCICommand
    {

    }
}
