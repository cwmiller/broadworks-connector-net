using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete an Access SIP Status Code mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18866""}]")]
    public class SystemTreatmentMappingAccessSIPStatusDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _sipStatusCode;

        [XmlElement(ElementName = "sipStatusCode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18866")]
        [MinInclusive(400)]
        [MaxInclusive(699)]
        public int SipStatusCode
        {
            get => _sipStatusCode;
            set
            {
                SipStatusCodeSpecified = true;
                _sipStatusCode = value;
            }
        }

        [XmlIgnore]
        protected bool SipStatusCodeSpecified { get; set; }

    }
}
