using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify group FAC code level and the list of feature access codes for a
    /// group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Note: choice element is only valid when useFeatureAccessCodeLevel is set
    /// to "Group", otherwise an ErrorResponse will be returned.
    /// In release 20 the "Call Recording" FAC name is changed to
    /// "Call Recording - Start".
    /// Replaced by: GroupFeatureAccessCodeModifyRequest21
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupFeatureAccessCodeModifyRequest21"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:9906"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:9910""}]}]")]
    public class GroupFeatureAccessCodeModifyRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:9906")]
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

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:9906")]
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

        protected BroadWorksConnector.Ocip.Models.GroupFeatureAccessCodeLevel _useFeatureAccessCodeLevel;

        [XmlElement(ElementName = "useFeatureAccessCodeLevel", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:9906")]
        public BroadWorksConnector.Ocip.Models.GroupFeatureAccessCodeLevel UseFeatureAccessCodeLevel
        {
            get => _useFeatureAccessCodeLevel;
            set
            {
                UseFeatureAccessCodeLevelSpecified = true;
                _useFeatureAccessCodeLevel = value;
            }
        }

        [XmlIgnore]
        protected bool UseFeatureAccessCodeLevelSpecified { get; set; }

        protected bool _restoreDefaultCodes;

        [XmlElement(ElementName = "restoreDefaultCodes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:9910")]
        public bool RestoreDefaultCodes
        {
            get => _restoreDefaultCodes;
            set
            {
                RestoreDefaultCodesSpecified = true;
                _restoreDefaultCodes = value;
            }
        }

        [XmlIgnore]
        protected bool RestoreDefaultCodesSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> _featureAccessCode = new List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry>();

        [XmlElement(ElementName = "featureAccessCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:9910")]
        public List<BroadWorksConnector.Ocip.Models.FeatureAccessCodeEntry> FeatureAccessCode
        {
            get => _featureAccessCode;
            set
            {
                FeatureAccessCodeSpecified = true;
                _featureAccessCode = value;
            }
        }

        [XmlIgnore]
        protected bool FeatureAccessCodeSpecified { get; set; }

    }
}
