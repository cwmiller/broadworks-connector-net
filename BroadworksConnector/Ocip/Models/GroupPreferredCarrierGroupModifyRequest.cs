using System;
using System.Xml.Serialization;
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
     
    public class GroupPreferredCarrierGroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify IntraLataCarrier {
            get => _intraLataCarrier;
            set {
                IntraLataCarrierSpecified = true;
                _intraLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool IntraLataCarrierSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify InterLataCarrier {
            get => _interLataCarrier;
            set {
                InterLataCarrierSpecified = true;
                _interLataCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InterLataCarrierSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupPreferredCarrierNameModify InternationalCarrier {
            get => _internationalCarrier;
            set {
                InternationalCarrierSpecified = true;
                _internationalCarrier = value;
            }
        }

        [XmlIgnore]
        public bool InternationalCarrierSpecified { get; set; }
        
    }
}
