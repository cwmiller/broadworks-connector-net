using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify system number activation setting.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26313""}]")]
    public class SystemNumberActivationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _useNumberActivation;

        [XmlElement(ElementName = "useNumberActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26313")]
        public bool UseNumberActivation
        {
            get => _useNumberActivation;
            set
            {
                UseNumberActivationSpecified = true;
                _useNumberActivation = value;
            }
        }

        [XmlIgnore]
        protected bool UseNumberActivationSpecified { get; set; }

    }
}
