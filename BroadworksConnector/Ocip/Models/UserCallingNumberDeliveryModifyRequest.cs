using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Calling Number Delivery.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""2739e54a6c7a2ab6abe092f89482573e:75""}]")]
    public class UserCallingNumberDeliveryModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"2739e54a6c7a2ab6abe092f89482573e:75")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private bool _isActiveForExternalCalls;

        [XmlElement(ElementName = "isActiveForExternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2739e54a6c7a2ab6abe092f89482573e:75")]
        public bool IsActiveForExternalCalls
        {
            get => _isActiveForExternalCalls;
            set
            {
                IsActiveForExternalCallsSpecified = true;
                _isActiveForExternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveForExternalCallsSpecified { get; set; }

        private bool _isActiveForInternalCalls;

        [XmlElement(ElementName = "isActiveForInternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"2739e54a6c7a2ab6abe092f89482573e:75")]
        public bool IsActiveForInternalCalls
        {
            get => _isActiveForInternalCalls;
            set
            {
                IsActiveForInternalCallsSpecified = true;
                _isActiveForInternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveForInternalCallsSpecified { get; set; }

    }
}
