using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaSetGetRequest.
    /// Returns a list of media names in the set.
    /// <see cref="SystemMediaSetGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:11096""}]")]
    public class SystemMediaSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _mediaName = new List<string>();

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:11096")]
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
        protected bool MediaNameSpecified { get; set; }

    }
}
