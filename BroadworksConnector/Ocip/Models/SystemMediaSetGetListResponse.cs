using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemMediaSetGetRequest.
    /// <see cref="SystemMediaSetGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12105""}]")]
    public class SystemMediaSetGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private List<string> _mediaSetName = new List<string>();

        [XmlElement(ElementName = "mediaSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12105")]
        [MinLength(1)]
        [MaxLength(80)]
        public List<string> MediaSetName
        {
            get => _mediaSetName;
            set
            {
                MediaSetNameSpecified = true;
                _mediaSetName = value;
            }
        }

        [XmlIgnore]
        protected bool MediaSetNameSpecified { get; set; }

    }
}
