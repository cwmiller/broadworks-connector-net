using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system Xsi policy profile entry.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:19575""}]")]
    public class SystemXsiPolicyProfileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.XsiPolicyProfileKey _xsiPolicyProfile;

        [XmlElement(ElementName = "xsiPolicyProfile", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19575")]
        public BroadWorksConnector.Ocip.Models.XsiPolicyProfileKey XsiPolicyProfile
        {
            get => _xsiPolicyProfile;
            set
            {
                XsiPolicyProfileSpecified = true;
                _xsiPolicyProfile = value;
            }
        }

        [XmlIgnore]
        protected bool XsiPolicyProfileSpecified { get; set; }

        private string _newXsiPolicyProfileName;

        [XmlElement(ElementName = "newXsiPolicyProfileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19575")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NewXsiPolicyProfileName
        {
            get => _newXsiPolicyProfileName;
            set
            {
                NewXsiPolicyProfileNameSpecified = true;
                _newXsiPolicyProfileName = value;
            }
        }

        [XmlIgnore]
        protected bool NewXsiPolicyProfileNameSpecified { get; set; }

        private string _description;

        [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19575")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Description
        {
            get => _description;
            set
            {
                DescriptionSpecified = true;
                _description = value;
            }
        }

        [XmlIgnore]
        protected bool DescriptionSpecified { get; set; }

        private int _maxTargetSubscription;

        [XmlElement(ElementName = "maxTargetSubscription", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:19575")]
        [MinInclusive(1)]
        [MaxInclusive(2147483647)]
        public int MaxTargetSubscription
        {
            get => _maxTargetSubscription;
            set
            {
                MaxTargetSubscriptionSpecified = true;
                _maxTargetSubscription = value;
            }
        }

        [XmlIgnore]
        protected bool MaxTargetSubscriptionSpecified { get; set; }

    }
}
