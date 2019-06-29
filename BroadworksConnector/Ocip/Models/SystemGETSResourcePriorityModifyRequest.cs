using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a GETS reserved Resource Priority.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10077""}]")]
    public class SystemGETSResourcePriorityModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _priorityValue;

        [XmlElement(ElementName = "priorityValue", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10077")]
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
        protected bool PriorityValueSpecified { get; set; }

        private string _newPriorityValue;

        [XmlElement(ElementName = "newPriorityValue", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10077")]
        [MinLength(3)]
        [MaxLength(80)]
        public string NewPriorityValue
        {
            get => _newPriorityValue;
            set
            {
                NewPriorityValueSpecified = true;
                _newPriorityValue = value;
            }
        }

        [XmlIgnore]
        protected bool NewPriorityValueSpecified { get; set; }

        private int _priorityLevel;

        [XmlElement(ElementName = "priorityLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10077")]
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
        protected bool PriorityLevelSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GETSPriorityClass _priorityClass;

        [XmlElement(ElementName = "priorityClass", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10077")]
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
        protected bool PriorityClassSpecified { get; set; }

    }
}
