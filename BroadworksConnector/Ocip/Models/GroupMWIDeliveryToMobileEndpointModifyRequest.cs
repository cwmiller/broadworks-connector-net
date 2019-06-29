using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group level MWI custom notifications settings.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// If the request is executed by a group administrator and modifies the useSettingLevel, the request is rejected.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""958b78cc2a785d78259c1e8a474eb40d:191""}]")]
    public class GroupMWIDeliveryToMobileEndpointModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:191")]
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
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:191")]
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

        private BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel _useSettingLevel;

        [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:191")]
        public BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointGroupSettingLevel UseSettingLevel
        {
            get => _useSettingLevel;
            set
            {
                UseSettingLevelSpecified = true;
                _useSettingLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UseSettingLevelSpecified { get; set; }

        private List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateActivation> _templateActivation = new List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateActivation>();

        [XmlElement(ElementName = "templateActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"958b78cc2a785d78259c1e8a474eb40d:191")]
        public List<BroadWorksConnector.Ocip.Models.MWIDeliveryToMobileEndpointTemplateActivation> TemplateActivation
        {
            get => _templateActivation;
            set
            {
                TemplateActivationSpecified = true;
                _templateActivation = value;
            }
        }

        [XmlIgnore]
        protected bool TemplateActivationSpecified { get; set; }

    }
}
