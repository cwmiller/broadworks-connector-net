using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemNumberPortabilityQueryGetRequest.
    /// Returns system Number Portability Query Parameters.
    /// <see cref="SystemNumberPortabilityQueryGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13340""}]")]
    public class SystemNumberPortabilityQueryGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _continueCallAsDialedOnTimeoutOrError;

        [XmlElement(ElementName = "continueCallAsDialedOnTimeoutOrError", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:13340")]
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
        [Group(@"da582a1f8028404e70d260cf1f891033:13340")]
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
