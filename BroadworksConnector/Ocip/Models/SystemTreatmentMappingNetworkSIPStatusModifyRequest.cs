using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the fields for a Network SIP Status Code mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17934""}]")]
    public class SystemTreatmentMappingNetworkSIPStatusModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _sipStatusCode;

        [XmlElement(ElementName = "sipStatusCode", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17934")]
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
        public bool SipStatusCodeSpecified { get; set; }

        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17934")]
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
        public bool TreatmentIdSpecified { get; set; }

    }
}
