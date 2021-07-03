using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system number formatting parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:13025""}]")]
    public class SystemNumberFormattingParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _applyFormattingToE164Numbers;

        [XmlElement(ElementName = "applyFormattingToE164Numbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:13025")]
        public bool ApplyFormattingToE164Numbers
        {
            get => _applyFormattingToE164Numbers;
            set
            {
                ApplyFormattingToE164NumbersSpecified = true;
                _applyFormattingToE164Numbers = value;
            }
        }

        [XmlIgnore]
        protected bool ApplyFormattingToE164NumbersSpecified { get; set; }

    }
}
