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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""31dec625cdd18e8228eb61ffb34ddc0e:569""}]")]
    public class UserPreferredCarrierUserModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:569")]
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

        protected BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify _intraLataCarrier;

        [XmlElement(ElementName = "intraLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:569")]
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
        protected bool IntraLataCarrierSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify _interLataCarrier;

        [XmlElement(ElementName = "interLataCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:569")]
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
        protected bool InterLataCarrierSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.UserPreferredCarrierNameModify _internationalCarrier;

        [XmlElement(ElementName = "internationalCarrier", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"31dec625cdd18e8228eb61ffb34ddc0e:569")]
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
        protected bool InternationalCarrierSpecified { get; set; }

    }
}
