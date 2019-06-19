using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a static entry in the Realm Routing Table.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2599""}]")]
    public class SystemBwDiameterRoutingRealmModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

        [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2599")]
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
        public bool InstanceSpecified { get; set; }

        private string _realm;

        [XmlElement(ElementName = "realm", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2599")]
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
        public bool RealmSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.BwDiameterApplicationId _applicationId;

        [XmlElement(ElementName = "applicationId", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2599")]
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
        public bool ApplicationIdSpecified { get; set; }

        private bool _default;

        [XmlElement(ElementName = "default", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2599")]
        public bool Default
        {
            get => _default;
            set
            {
                DefaultSpecified = true;
                _default = value;
            }
        }

        [XmlIgnore]
        public bool DefaultSpecified { get; set; }

    }
}
