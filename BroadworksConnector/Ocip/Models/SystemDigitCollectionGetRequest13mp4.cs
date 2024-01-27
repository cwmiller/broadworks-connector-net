using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request the system's digit collection attributes.
    /// The response is either a SystemDigitCollectionGetResponse13mp4 or an ErrorResponse.
    /// <see cref="SystemDigitCollectionGetResponse13mp4"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:9356""}]")]
    public class SystemDigitCollectionGetRequest13mp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemDigitCollectionGetResponse13mp4>
    {

    }
}
