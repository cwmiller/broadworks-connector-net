using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Get the utilization of a single DN.
    /// The response is either SystemDnGetUtilizationResponse or ErrorResponse.
    /// Replaced By: SystemDnGetUtilizationRequest14sp3
    /// <see cref="SystemDnGetUtilizationResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemDnGetUtilizationRequest14sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26362""}]")]
    public class SystemDnGetUtilizationRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _phoneNumber;

        [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26362")]
        [MinLength(1)]
        [MaxLength(23)]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                PhoneNumberSpecified = true;
                _phoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberSpecified { get; set; }

    }
}
