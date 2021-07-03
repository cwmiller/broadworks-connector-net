using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the currently configured carriers for a group.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:93""}]")]
    public class GroupPreferredCarrierGroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:93")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:93")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:93")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify IntraLataCarrier
        {
            get => _intraLataCarrier;
            set
            {
                IntraLataCarrierSpecified = true;
                _intraLataCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool IntraLataCarrierSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:93")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify InterLataCarrier
        {
            get => _interLataCarrier;
            set
            {
                InterLataCarrierSpecified = true;
                _interLataCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool InterLataCarrierSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:93")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify InternationalCarrier
        {
            get => _internationalCarrier;
            set
            {
                InternationalCarrierSpecified = true;
                _internationalCarrier = value;
            }
        }

        [XmlIgnore]
        protected bool InternationalCarrierSpecified { get; set; }

    }
}
