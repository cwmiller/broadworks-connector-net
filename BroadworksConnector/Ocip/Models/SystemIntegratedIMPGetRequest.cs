using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Integrated IMP service attributes.
    /// The response is either SystemIntegratedIMPGetResponse or ErrorResponse.
    /// 
    /// Replaced by SystemIntegratedIMPGetRequest19.
    /// <see cref="SystemIntegratedIMPGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemIntegratedIMPGetRequest19"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemIntegratedIMPGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

    }
}
