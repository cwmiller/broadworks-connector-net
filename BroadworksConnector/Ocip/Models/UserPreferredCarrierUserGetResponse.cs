using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to a UserPreferredCarrierUserGetRequest.
    /// <see cref="UserPreferredCarrierUserGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""74a46a9bfccb54713c1d19735843f1df:551""}]")]
    public class UserPreferredCarrierUserGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierName _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:551")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierName IntraLataCarrier
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

        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierName _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:551")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierName InterLataCarrier
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

        private BroadWorksConnector.Ocip.Models.UserPreferredCarrierName _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        [Group(@"74a46a9bfccb54713c1d19735843f1df:551")]
        public BroadWorksConnector.Ocip.Models.UserPreferredCarrierName InternationalCarrier
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
