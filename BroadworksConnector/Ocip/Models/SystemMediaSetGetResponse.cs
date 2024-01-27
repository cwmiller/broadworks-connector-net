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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12259""}]")]
    public class SystemMediaSetGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected List<string> _mediaName = new List<string>();

        [XmlElement(ElementName = "mediaName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12259")]
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
