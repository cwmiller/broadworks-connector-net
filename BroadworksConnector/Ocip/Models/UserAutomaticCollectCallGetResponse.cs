using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserAutomaticCollectCallGetRequest.
    /// Returns user Automatic Collect Call service settings.
    /// <see cref="UserAutomaticCollectCallGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""af1b47d7cab3335a81456e64e42371b0:174""}]")]
    public class UserAutomaticCollectCallGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enableAutomaticCollectCall;

        [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
        [Group(@"af1b47d7cab3335a81456e64e42371b0:174")]
        public bool EnableAutomaticCollectCall
        {
            get => _enableAutomaticCollectCall;
            set
            {
                EnableAutomaticCollectCallSpecified = true;
                _enableAutomaticCollectCall = value;
            }
        }

        [XmlIgnore]
        public bool EnableAutomaticCollectCallSpecified { get; set; }

    }
}
