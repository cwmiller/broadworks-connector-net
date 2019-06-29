using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserNumberPortabilityAnnouncementGetRequest.
    /// The response contains the user Number Portability attributes.
    /// <see cref="UserNumberPortabilityAnnouncementGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6abb48a2d0672804f15670b4afa7ec02:59""}]")]
    public class UserNumberPortabilityAnnouncementGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _enable;

        [XmlElement(ElementName = "enable", IsNullable = false, Namespace = "")]
        [Group(@"6abb48a2d0672804f15670b4afa7ec02:59")]
        public bool Enable
        {
            get => _enable;
            set
            {
                EnableSpecified = true;
                _enable = value;
            }
        }

        [XmlIgnore]
        protected bool EnableSpecified { get; set; }

    }
}
