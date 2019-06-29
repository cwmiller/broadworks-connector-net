using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a Q850 Cause Value mapping.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:17968""}]")]
    public class SystemTreatmentMappingQ850CauseDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private int _q850CauseValue;

        [XmlElement(ElementName = "q850CauseValue", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:17968")]
        [MinInclusive(1)]
        [MaxInclusive(256)]
        public int Q850CauseValue
        {
            get => _q850CauseValue;
            set
            {
                Q850CauseValueSpecified = true;
                _q850CauseValue = value;
            }
        }

        [XmlIgnore]
        protected bool Q850CauseValueSpecified { get; set; }

    }
}
