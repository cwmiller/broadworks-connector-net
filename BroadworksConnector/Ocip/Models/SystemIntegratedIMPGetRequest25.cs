using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Integrated IMP service attributes.
    /// The response is either SystemIntegratedIMPGetResponse25 or ErrorResponse.
    /// <see cref="SystemIntegratedIMPGetResponse25"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemIntegratedIMPGetRequest25 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemIntegratedIMPGetResponse25>
    {

    }
}
