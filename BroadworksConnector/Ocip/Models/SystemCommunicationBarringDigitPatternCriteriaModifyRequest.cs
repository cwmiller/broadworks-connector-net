using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify an existing Communication Barring Digit Pattern Criteria.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:5714""}]")]
    public class SystemCommunicationBarringDigitPatternCriteriaModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5714")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Name
        {
            get => _name;
            set
            {
                NameSpecified = true;
                _name = value;
            }
        }

        [XmlIgnore]
        protected bool NameSpecified { get; set; }

        private string _newName;

        [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5714")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewName
        {
            get => _newName;
            set
            {
                NewNameSpecified = true;
                _newName = value;
            }
        }

        [XmlIgnore]
        protected bool NewNameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5714")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private List<string> _addMatchDigitPattern = new List<string>();

        [XmlElement(ElementName = "addMatchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5714")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> AddMatchDigitPattern
        {
            get => _addMatchDigitPattern;
            set
            {
                AddMatchDigitPatternSpecified = true;
                _addMatchDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool AddMatchDigitPatternSpecified { get; set; }

        private List<string> _deleteMatchDigitPattern = new List<string>();

        [XmlElement(ElementName = "deleteMatchDigitPattern", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:5714")]
        [MinLength(1)]
        [MaxLength(160)]
        public List<string> DeleteMatchDigitPattern
        {
            get => _deleteMatchDigitPattern;
            set
            {
                DeleteMatchDigitPatternSpecified = true;
                _deleteMatchDigitPattern = value;
            }
        }

        [XmlIgnore]
        protected bool DeleteMatchDigitPatternSpecified { get; set; }

    }
}
