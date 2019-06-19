using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete an alternate call indicator from the list of expensive alternate call indicators.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:8833""}]")]
    public class SystemExpensiveCallTypeDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _alternateCallIndicator;

        [XmlElement(ElementName = "alternateCallIndicator", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:8833")]
        [MinLength(1)]
        [MaxLength(64)]
        public string AlternateCallIndicator
        {
            get => _alternateCallIndicator;
            set
            {
                AlternateCallIndicatorSpecified = true;
                _alternateCallIndicator = value;
            }
        }

        [XmlIgnore]
        public bool AlternateCallIndicatorSpecified { get; set; }

    }
}
