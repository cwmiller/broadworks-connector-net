using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Calling Name Delivery.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""06a92852394dc03f09084365420b7b9e:75""}]")]
    public class UserCallingNameDeliveryModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"06a92852394dc03f09084365420b7b9e:75")]
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

        protected bool _isActiveForExternalCalls;

        [XmlElement(ElementName = "isActiveForExternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"06a92852394dc03f09084365420b7b9e:75")]
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

        protected bool _isActiveForInternalCalls;

        [XmlElement(ElementName = "isActiveForInternalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"06a92852394dc03f09084365420b7b9e:75")]
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
