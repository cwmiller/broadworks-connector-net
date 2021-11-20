using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the SIP cause value for a given diversion reason.
    /// The response is either a SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17509""}]")]
    public class SystemSIPDiversionReasonModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private BroadWorksConnector.Ocip.Models.SIPDiversionReason _diversionReason;

        [XmlElement(ElementName = "diversionReason", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17509")]
        public BroadWorksConnector.Ocip.Models.SIPDiversionReason DiversionReason
        {
            get => _diversionReason;
            set
            {
                DiversionReasonSpecified = true;
                _diversionReason = value;
            }
        }

        [XmlIgnore]
        protected bool DiversionReasonSpecified { get; set; }

        private string _causeValue;

        [XmlElement(ElementName = "causeValue", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17509")]
        [Length(3)]
        public string CauseValue
        {
            get => _causeValue;
            set
            {
                CauseValueSpecified = true;
                _causeValue = value;
            }
        }

        [XmlIgnore]
        protected bool CauseValueSpecified { get; set; }

    }
}
