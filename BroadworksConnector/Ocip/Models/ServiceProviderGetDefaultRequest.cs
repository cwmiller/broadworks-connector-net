using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the default profile for a service provider or enterprise.
    /// The response is either a ServiceProviderGetDefaultResponse or an ErrorResponse.
    /// <see cref="ServiceProviderGetDefaultResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:4413""}]")]
    public class ServiceProviderGetDefaultRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
