using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system interface attributes for Messaging Server/BroadCloud.
    /// The response is either SystemBroadCloudGetResponse or ErrorResponse.
    /// <see cref="SystemBroadCloudGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemBroadCloudGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
