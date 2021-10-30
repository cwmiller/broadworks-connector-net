using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Media Set.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12153""}]")]
    public class SystemMediaSetModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _setName;

        [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12153")]
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
        protected bool SetNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ReplacementMediaNameList _mediaNameList;

        [XmlElement(ElementName = "mediaNameList", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12153")]
        public BroadWorksConnector.Ocip.Models.ReplacementMediaNameList MediaNameList
        {
            get => _mediaNameList;
            set
            {
                MediaNameListSpecified = true;
                _mediaNameList = value;
            }
        }

        [XmlIgnore]
        protected bool MediaNameListSpecified { get; set; }

    }
}
