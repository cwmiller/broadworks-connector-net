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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:17736""}]")]
    public class SystemSIPDiversionReasonModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.SIPDiversionReason _diversionReason;

        [XmlElement(ElementName = "diversionReason", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17736")]
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

        protected string _causeValue;

        [XmlElement(ElementName = "causeValue", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:17736")]
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
