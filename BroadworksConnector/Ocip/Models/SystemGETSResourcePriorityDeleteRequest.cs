using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a GETS Resource Priority.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10033""}]")]
    public class SystemGETSResourcePriorityDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _priorityValue;

        [XmlElement(ElementName = "priorityValue", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10033")]
        [MinLength(3)]
        [MaxLength(80)]
        public string PriorityValue
        {
            get => _priorityValue;
            set
            {
                PriorityValueSpecified = true;
                _priorityValue = value;
            }
        }

        [XmlIgnore]
        public bool PriorityValueSpecified { get; set; }

    }
}
