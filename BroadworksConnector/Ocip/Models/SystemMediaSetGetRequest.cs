using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to get a Media Set.
    /// The response is either a SystemMediaSetGetResponse or an ErrorResponse.
    /// <see cref="SystemMediaSetGetResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12121""}]")]
    public class SystemMediaSetGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMediaSetGetResponse>
    {

        private string _setName;

        [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12121")]
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

    }
}
