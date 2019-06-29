using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserTwoStageDialingGetRequest13Mp20.
    /// <see cref="UserTwoStageDialingGetRequest13Mp20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2a1428f64736d8f970ea802e5a73c495:146""}]")]
    public class UserTwoStageDialingGetResponse13Mp20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"2a1428f64736d8f970ea802e5a73c495:146")]
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

        private bool _allowActivationWithUserAddresses;

        [XmlElement(ElementName = "allowActivationWithUserAddresses", IsNullable = false, Namespace = "")]
        [Group(@"2a1428f64736d8f970ea802e5a73c495:146")]
        public bool AllowActivationWithUserAddresses
        {
            get => _allowActivationWithUserAddresses;
            set
            {
                AllowActivationWithUserAddressesSpecified = true;
                _allowActivationWithUserAddresses = value;
            }
        }

        [XmlIgnore]
        protected bool AllowActivationWithUserAddressesSpecified { get; set; }

    }
}
