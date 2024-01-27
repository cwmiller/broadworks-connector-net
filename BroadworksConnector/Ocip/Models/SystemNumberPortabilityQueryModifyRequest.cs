using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify system Number Portability Query Parameters.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13357""}]")]
    public class SystemNumberPortabilityQueryModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _continueCallAsDialedOnTimeoutOrError;

        [XmlElement(ElementName = "continueCallAsDialedOnTimeoutOrError", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13357")]
        public bool ContinueCallAsDialedOnTimeoutOrError
        {
            get => _continueCallAsDialedOnTimeoutOrError;
            set
            {
                ContinueCallAsDialedOnTimeoutOrErrorSpecified = true;
                _continueCallAsDialedOnTimeoutOrError = value;
            }
        }

        [XmlIgnore]
        protected bool ContinueCallAsDialedOnTimeoutOrErrorSpecified { get; set; }

        protected int _numberPortabilityNameLookupTimeoutMilliseconds;

        [XmlElement(ElementName = "numberPortabilityNameLookupTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13357")]
        [MinInclusive(100)]
        [MaxInclusive(10000)]
        public int NumberPortabilityNameLookupTimeoutMilliseconds
        {
            get => _numberPortabilityNameLookupTimeoutMilliseconds;
            set
            {
                NumberPortabilityNameLookupTimeoutMillisecondsSpecified = true;
                _numberPortabilityNameLookupTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool NumberPortabilityNameLookupTimeoutMillisecondsSpecified { get; set; }

    }
}
