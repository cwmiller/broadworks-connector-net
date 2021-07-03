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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13187""}]")]
    public class SystemNumberPortabilityQueryModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _continueCallAsDialedOnTimeoutOrError;

        [XmlElement(ElementName = "continueCallAsDialedOnTimeoutOrError", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13187")]
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

        private int _numberPortabilityNameLookupTimeoutMilliseconds;

        [XmlElement(ElementName = "numberPortabilityNameLookupTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13187")]
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
