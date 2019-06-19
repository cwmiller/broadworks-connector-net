using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to add a Media Set.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11018""}]")]
    public class SystemMediaSetAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _setName;

        [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11018")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SetName
        {
            get => _setName;
            set
            {
                SetNameSpecified = true;
                _setName = value;
            }
        }

        [XmlIgnore]
        public bool SetNameSpecified { get; set; }

        private List<string> _mediaName = new List<string>();

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11018")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> MediaName
        {
            get => _mediaName;
            set
            {
                MediaNameSpecified = true;
                _mediaName = value;
            }
        }

        [XmlIgnore]
        public bool MediaNameSpecified { get; set; }

    }
}
