using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Add a GETS Resource Priority.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10015""}]")]
    public class SystemGETSResourcePriorityAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _priorityValue;

        [XmlElement(ElementName = "priorityValue", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10015")]
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

        private int _priorityLevel;

        [XmlElement(ElementName = "priorityLevel", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10015")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int PriorityLevel
        {
            get => _priorityLevel;
            set
            {
                PriorityLevelSpecified = true;
                _priorityLevel = value;
            }
        }

        [XmlIgnore]
        public bool PriorityLevelSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GETSPriorityClass _priorityClass;

        [XmlElement(ElementName = "priorityClass", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10015")]
        public BroadWorksConnector.Ocip.Models.GETSPriorityClass PriorityClass
        {
            get => _priorityClass;
            set
            {
                PriorityClassSpecified = true;
                _priorityClass = value;
            }
        }

        [XmlIgnore]
        public bool PriorityClassSpecified { get; set; }

    }
}
