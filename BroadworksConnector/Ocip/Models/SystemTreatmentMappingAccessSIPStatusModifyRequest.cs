using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the fields for an Access SIP Status Code mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:18913""}]")]
    public class SystemTreatmentMappingAccessSIPStatusModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _sipStatusCode;

        [XmlElement(ElementName = "sipStatusCode", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:18913")]
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

        protected string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:18913")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentIdSpecified { get; set; }

    }
}
