using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the data associated with Call Processing Policy for system service instances.
    /// The response is either SystemSystemServiceCallProcessingPoliciesGetResponse or ErrorResponse.
    /// <see cref="SystemSystemServiceCallProcessingPoliciesGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemSystemServiceCallProcessingPoliciesGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
