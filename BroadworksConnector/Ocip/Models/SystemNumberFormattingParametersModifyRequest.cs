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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:13195""}]")]
    public class SystemNumberFormattingParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _applyFormattingToE164Numbers;

        [XmlElement(ElementName = "applyFormattingToE164Numbers", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:13195")]
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
