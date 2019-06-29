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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""5999b2d9c77e3f1626cad635ea37a4a7:57""}]")]
    public class UserDoNotDisturbGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"5999b2d9c77e3f1626cad635ea37a4a7:57")]
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

        private bool _ringSplash;

        [XmlElement(ElementName = "ringSplash", IsNullable = false, Namespace = "")]
        [Group(@"5999b2d9c77e3f1626cad635ea37a4a7:57")]
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
