using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSMDIMessageDeskGetRequest.
    /// <see cref="UserSMDIMessageDeskGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ee7bb69368e23a56a82c5d9cf07b5433:275""}]")]
    public class UserSMDIMessageDeskGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:275")]
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

        private string _messageDeskNumber;

        [XmlElement(ElementName = "messageDeskNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ee7bb69368e23a56a82c5d9cf07b5433:275")]
        [MinLength(1)]
        [MaxLength(3)]
        public string MessageDeskNumber
        {
            get => _messageDeskNumber;
            set
            {
                MessageDeskNumberSpecified = true;
                _messageDeskNumber = value;
            }
        }

        [XmlIgnore]
        protected bool MessageDeskNumberSpecified { get; set; }

    }
}
