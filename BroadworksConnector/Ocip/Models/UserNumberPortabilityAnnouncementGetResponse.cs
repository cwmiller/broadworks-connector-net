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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""522c098907e72f4cd4af52b0c730f9c6:59""}]")]
    public class UserNumberPortabilityAnnouncementGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _enable;

        [XmlElement(ElementName = "enable", IsNullable = false, Namespace = "")]
        [Group(@"522c098907e72f4cd4af52b0c730f9c6:59")]
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
