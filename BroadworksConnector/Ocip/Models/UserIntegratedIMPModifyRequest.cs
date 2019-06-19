using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the Integrated IMP specific service attribute for the user.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// If the impId element is set in the request, the impId element does
    /// not take effect on the service for the user unless the request also
    /// has the isActive element set to true to turn the service from off
    /// to on.
    /// If impId is based on an alternate user ID and the impId and userId
    /// are identical, isAlternateImpId should be set to true to determine
    /// that impId is the user's alternate ID.
    /// The following elements are only used in AS data mode and ignored in
    /// XS data mode:
    /// impId
    /// isAlternateImpId
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""23389100b68cef3aa07ee12ac7a2bd16:380""}]")]
    public class UserIntegratedIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:380")]
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
        public bool UserIdSpecified { get; set; }

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:380")]
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
        public bool IsActiveSpecified { get; set; }

        private string _impId;

        [XmlElement(ElementName = "impId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:380")]
        [MinLength(1)]
        [MaxLength(196)]
        public string ImpId
        {
            get => _impId;
            set
            {
                ImpIdSpecified = true;
                _impId = value;
            }
        }

        [XmlIgnore]
        public bool ImpIdSpecified { get; set; }

        private bool _isAlternateImpId;

        [XmlElement(ElementName = "isAlternateImpId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"23389100b68cef3aa07ee12ac7a2bd16:380")]
        public bool IsAlternateImpId
        {
            get => _isAlternateImpId;
            set
            {
                IsAlternateImpIdSpecified = true;
                _isAlternateImpId = value;
            }
        }

        [XmlIgnore]
        public bool IsAlternateImpIdSpecified { get; set; }

    }
}
