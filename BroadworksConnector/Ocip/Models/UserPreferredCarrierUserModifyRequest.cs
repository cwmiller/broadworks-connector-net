using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the currently configured preferred carriers for a user.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:569""}]")]
    public class UserPreferredCarrierUserModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:569")]
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

        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:569")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify IntraLataCarrier
        {
            get => _intraLataCarrier;
            set
            {
                IntraLataCarrierSpecified = true;
                _intraLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool IntraLataCarrierSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:569")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify InterLataCarrier
        {
            get => _interLataCarrier;
            set
            {
                InterLataCarrierSpecified = true;
                _interLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InterLataCarrierSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:569")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify InternationalCarrier
        {
            get => _internationalCarrier;
            set
            {
                InternationalCarrierSpecified = true;
                _internationalCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InternationalCarrierSpecified { get; set; }

    }
}
