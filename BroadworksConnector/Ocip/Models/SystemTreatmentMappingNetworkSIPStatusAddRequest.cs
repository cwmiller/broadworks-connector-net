using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a Network SIP Status Code mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:18943""}]")]
    public class SystemTreatmentMappingNetworkSIPStatusAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private int _sipStatusCode;

        [XmlElement(ElementName = "sipStatusCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18943")]
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

        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:18943")]
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
