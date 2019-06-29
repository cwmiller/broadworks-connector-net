using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a media associated with a media group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10750""}]")]
    public class SystemMediaGroupCodecModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _name;

        [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10750")]
        [MinLength(1)]
        [MaxLength(80)]
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

        private string _codecName;

        [XmlElement(ElementName = "codecName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10750")]
        [MinLength(1)]
        [MaxLength(80)]
        public string CodecName
        {
            get => _codecName;
            set
            {
                CodecNameSpecified = true;
                _codecName = value;
            }
        }

        [XmlIgnore]
        protected bool CodecNameSpecified { get; set; }

        private int _codecWeight;

        [XmlElement(ElementName = "codecWeight", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10750")]
        [MinInclusive(1)]
        [MaxInclusive(1000)]
        public int CodecWeight
        {
            get => _codecWeight;
            set
            {
                CodecWeightSpecified = true;
                _codecWeight = value;
            }
        }

        [XmlIgnore]
        protected bool CodecWeightSpecified { get; set; }

    }
}
