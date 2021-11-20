using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the system Integrated IMP service attributes.
    /// The response is either SystemIntegratedIMPGetResponse19 or ErrorResponse.
    /// 
    /// Replaced by: SystemIntegratedIMPGetRequest21 in AS data mode
    /// <see cref="SystemIntegratedIMPGetResponse19"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemIntegratedIMPGetRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]


    public class SystemIntegratedIMPGetRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemIntegratedIMPGetResponse19>
    {

    }
}
