using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the Device Activation policy of the system.
    /// The response is either a SystemDeviceActivationPolicyGetResponse or an ErrorResponse.
    /// <see cref="SystemDeviceActivationPolicyGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemDeviceActivationPolicyGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
