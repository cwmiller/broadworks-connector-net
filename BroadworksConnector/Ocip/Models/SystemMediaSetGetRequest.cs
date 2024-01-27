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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:12243""}]")]
    public class SystemMediaSetGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.SystemMediaSetGetResponse>
    {

        protected string _setName;

        [XmlElement(ElementName = "setName", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:12243")]
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
