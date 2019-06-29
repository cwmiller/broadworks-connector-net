using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to delete an Intercept User number(s) from the system.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""88893c72abbbb9aaf5aecca970191d94:159""}]")]
    public class SystemInterceptUserDeleteDnListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private List<string> _phoneNumbers = new List<string>();

        [XmlElement(ElementName = "phoneNumbers", IsNullable = false, Namespace = "")]
        [Group(@"88893c72abbbb9aaf5aecca970191d94:159")]
        [MinLength(1)]
        [MaxLength(23)]
        public List<string> PhoneNumbers
        {
            get => _phoneNumbers;
            set
            {
                PhoneNumbersSpecified = true;
                _phoneNumbers = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumbersSpecified { get; set; }

    }
}
