using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserDoNotDisturbGetRequest.
    /// <see cref="UserDoNotDisturbGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f424ffe4eea042849235863d758363ec:57""}]")]
    public class UserDoNotDisturbGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"f424ffe4eea042849235863d758363ec:57")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected bool _ringSplash;

        [XmlElement(ElementName = "ringSplash", IsNullable = false, Namespace = "")]
        [Group(@"f424ffe4eea042849235863d758363ec:57")]
        public bool RingSplash
        {
            get => _ringSplash;
            set
            {
                RingSplashSpecified = true;
                _ringSplash = value;
            }
        }

        [XmlIgnore]
        protected bool RingSplashSpecified { get; set; }

    }
}
