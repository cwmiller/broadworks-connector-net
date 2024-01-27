using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Delete a static entry in the Realm Routing Table.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2955""}]")]
    public class SystemBwDiameterRoutingRealmDeleteRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

        [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2955")]
        public BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance Instance
        {
            get => _instance;
            set
            {
                InstanceSpecified = true;
                _instance = value;
            }
        }

        [XmlIgnore]
        protected bool InstanceSpecified { get; set; }

        protected string _realm;

        [XmlElement(ElementName = "realm", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2955")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Realm
        {
            get => _realm;
            set
            {
                RealmSpecified = true;
                _realm = value;
            }
        }

        [XmlIgnore]
        protected bool RealmSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.BwDiameterApplicationId _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2955")]
        public BroadWorksConnector.Ocip.Models.BwDiameterApplicationId ApplicationId
        {
            get => _applicationId;
            set
            {
                ApplicationIdSpecified = true;
                _applicationId = value;
            }
        }

        [XmlIgnore]
        protected bool ApplicationIdSpecified { get; set; }

    }
}
